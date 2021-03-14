using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectExecutor_AnimFeature : gameEffectExecutor
	{
		private CName _key;
		private CHandle<animAnimFeature> _animFeature;
		private CEnum<gameEffectExecutor_AnimFeatureApplyTo> _applyTo;

		[Ordinal(1)] 
		[RED("key")] 
		public CName Key
		{
			get
			{
				if (_key == null)
				{
					_key = (CName) CR2WTypeManager.Create("CName", "key", cr2w, this);
				}
				return _key;
			}
			set
			{
				if (_key == value)
				{
					return;
				}
				_key = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("animFeature")] 
		public CHandle<animAnimFeature> AnimFeature
		{
			get
			{
				if (_animFeature == null)
				{
					_animFeature = (CHandle<animAnimFeature>) CR2WTypeManager.Create("handle:animAnimFeature", "animFeature", cr2w, this);
				}
				return _animFeature;
			}
			set
			{
				if (_animFeature == value)
				{
					return;
				}
				_animFeature = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("applyTo")] 
		public CEnum<gameEffectExecutor_AnimFeatureApplyTo> ApplyTo
		{
			get
			{
				if (_applyTo == null)
				{
					_applyTo = (CEnum<gameEffectExecutor_AnimFeatureApplyTo>) CR2WTypeManager.Create("gameEffectExecutor_AnimFeatureApplyTo", "applyTo", cr2w, this);
				}
				return _applyTo;
			}
			set
			{
				if (_applyTo == value)
				{
					return;
				}
				_applyTo = value;
				PropertySet(this);
			}
		}

		public gameEffectExecutor_AnimFeature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
