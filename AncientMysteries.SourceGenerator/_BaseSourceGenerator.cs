﻿namespace AncientMysteries.SourceGenerator
{
    public abstract class _BaseSourceGenerator : _BaseGenerator
    {
        public virtual string Using => _CompileSettings.DefaultUsing + "\n";

        public override void Execute(GeneratorExecutionContext context)
        {
            
            var contentBuilder = SBPool.Rent();
            Generate(context, contentBuilder);
            string source = @$"{Using}namespace {_CompileSettings.Namespace}
            {{
                {contentBuilder.ToString()}
            }}
            ";
            // Wht not? Cuz it's fucking suffering that using SourceGenerator In NetFX
            context.AddSource(UniqueName + ".cs", SourceText.From(source, Encoding.UTF8));
            //File.WriteAllText(context.GetProjectLocaltion() + "/_Generated/" + UniqueName + ".cs", source);
        }

        public abstract void Generate(GeneratorExecutionContext context, StringBuilder sb);

        public override void Initialize(GeneratorInitializationContext context) { }
    }
}
