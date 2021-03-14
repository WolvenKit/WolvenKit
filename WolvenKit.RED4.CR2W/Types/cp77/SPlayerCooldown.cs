using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SPlayerCooldown : CVariable
	{
		private TweakDBID _effectID;
		private TweakDBID _instigatorID;

		[Ordinal(0)] 
		[RED("effectID")] 
		public TweakDBID EffectID
		{
			get
			{
				if (_effectID == null)
				{
					_effectID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "effectID", cr2w, this);
				}
				return _effectID;
			}
			set
			{
				if (_effectID == value)
				{
					return;
				}
				_effectID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("instigatorID")] 
		public TweakDBID InstigatorID
		{
			get
			{
				if (_instigatorID == null)
				{
					_instigatorID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "instigatorID", cr2w, this);
				}
				return _instigatorID;
			}
			set
			{
				if (_instigatorID == value)
				{
					return;
				}
				_instigatorID = value;
				PropertySet(this);
			}
		}

		public SPlayerCooldown(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
