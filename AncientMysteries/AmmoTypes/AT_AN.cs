﻿using DuckGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AncientMysteries.AmmoTypes
{
    public sealed class AT_AN : AmmoType
    {
        public SpriteMap _spriteMap = TexHelper.ModSpriteMap("novaFrm.png", 32, 32, true);

        public AT_AN()
        {
            accuracy = 1f;
            range = 275f;
            penetration = 20000000f;
            rangeVariation = 10f;
            bulletSpeed = 2;
            this.speedVariation = 0.5f;
            bulletLength = 50;
            this.bulletColor = Color.LightYellow;
            bulletThickness = 2;
            this.sprite = _spriteMap;
            _spriteMap.AddAnimation("loop", 0.15f, true, 0, 1, 2, 3);
            _spriteMap.SetAnimation("loop");
            _spriteMap.CenterOrigin();
        }

    }
}