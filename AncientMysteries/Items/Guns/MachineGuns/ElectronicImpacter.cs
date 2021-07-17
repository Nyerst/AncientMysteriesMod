﻿namespace AncientMysteries.Items.Guns.MachineGuns
{
    [EditorGroup(g_rifles)]
    [MetaImage(t_)]
    [MetaInfo(Lang.english, "Electronic Impacter", "desc")]
    [MetaInfo(Lang.schinese, "", "")]
    public sealed partial class ElectronicImpacter : AMGun
	{
		public override string GetLocalizedName(Lang lang) => lang switch
		{
			Lang.schinese => "雷电撞击",
			_ => "Electronic Impacter",
		};
		public override string GetLocalizedDescription(Lang lang) => lang switch
		{
			Lang.schinese => "但是，它为什么是绿色的呢？",
			_ => "But, why is it green?",
		};
		public ElectronicImpacter(float xval, float yval) : base(xval, yval)
		{
			ammo = 80;
			_ammoType = new ElectronicImpacter_AmmoType();
			_type = "gun";
			this.ReadyToRunWithFrames(t_Gun_ElectronicImpacter);
			_flare.color = Color.Transparent;
			BarrelSmokeFuckOff();
			_fireRumble = RumbleIntensity.Kick;
			_barrelOffsetTL = new Vec2(24f, 5f);
			_fireSound = "laserRifle";
			_fireSoundPitch = 0.9f;
			_fireWait = 0.9f;
			_kickForce = 0f;
			_fullAuto = true;
			_bulletColor = Color.Lime;
		}
    }
}
