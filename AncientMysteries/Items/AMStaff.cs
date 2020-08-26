﻿using AncientMysteries.AmmoTypes;
using AncientMysteries.Localization;
using DuckGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AncientMysteries.Items
{
    public abstract class AMStaff : AMGun, IAMLocalizable
    {
        public StateBinding castTimeBinding = new StateBinding("castTime");

        public StateBinding castWaitValBinding = new StateBinding("_castWaitVal");

        public float _holdAngle = 0.8f;

        public float _fireAngle = 1.1f;

        public float _castSpeed = 0.04f;

        public float _castTime = 0f;

        public float _castWaitVal = 0f;

        public float _castWait = 1f;

        public bool IsSpelling
        {
            get
            {
                return this._castTime != 0f;
            }
        }

        public AMStaff(float xval, float yval) : base(xval, yval)
        {
            this._ammoType = new AT_None();
            this._type = "gun";
            this.ammo = 4;
            _flare.color = Color.Transparent;
            this._holdOffset = new Vec2(-5, -3);
            BarrelSmokeFuckOff();
            this._fireSound = "laserRifle";
            this._fireSoundPitch = 0.9f;
            _fullAuto = true;
            _editorName = GetLocalizedName(AMLocalization.Current);
        }

        public virtual void OnSpelling()
        {
        }

        public virtual void EndSpelling()
        {
        }

        public virtual void OnReleaseSpell()
        {
        }

        public override sealed void Fire()
        {
        }

        public override void OnReleaseAction()
        {
            base.OnReleaseAction();
            if (_castWaitVal == 0)
            {
                bool flag = base.duck != null;
                if (flag)
                {
                    this.OnReleaseSpell();
                    this.EndSpelling();
                    _castWaitVal = _castWait;
                }
                this._castTime = 0f;
            }
        }

        public override void Update()
        {
            base.Update();
            if (action && _castWaitVal == 0)
            {
                if (_castTime <= 1)
                    _castTime += _castSpeed;
                else _castTime = 1;
            }
            if (_castWaitVal > 0)
            {
                _castWaitVal -= 0.04f;
            }
            else
            {
                _castWaitVal = 0;
            }
            if (duck != null)
            {
                base.handAngle = offDir * MathHelper.Lerp(_holdAngle, _fireAngle, _castTime);
            }
        }
    }
}
