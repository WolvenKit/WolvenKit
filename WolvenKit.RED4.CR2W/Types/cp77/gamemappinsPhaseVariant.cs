using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemappinsPhaseVariant : gamemappinsIPointOfInterestVariant
	{
		private TweakDBID _mappinType;
		private CEnum<gamedataMappinPhase> _phase;
		private CEnum<gamedataMappinVariant> _variant;

		[Ordinal(0)] 
		[RED("mappinType")] 
		public TweakDBID MappinType
		{
			get
			{
				if (_mappinType == null)
				{
					_mappinType = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "mappinType", cr2w, this);
				}
				return _mappinType;
			}
			set
			{
				if (_mappinType == value)
				{
					return;
				}
				_mappinType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("phase")] 
		public CEnum<gamedataMappinPhase> Phase
		{
			get
			{
				if (_phase == null)
				{
					_phase = (CEnum<gamedataMappinPhase>) CR2WTypeManager.Create("gamedataMappinPhase", "phase", cr2w, this);
				}
				return _phase;
			}
			set
			{
				if (_phase == value)
				{
					return;
				}
				_phase = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("variant")] 
		public CEnum<gamedataMappinVariant> Variant
		{
			get
			{
				if (_variant == null)
				{
					_variant = (CEnum<gamedataMappinVariant>) CR2WTypeManager.Create("gamedataMappinVariant", "variant", cr2w, this);
				}
				return _variant;
			}
			set
			{
				if (_variant == value)
				{
					return;
				}
				_variant = value;
				PropertySet(this);
			}
		}

		public gamemappinsPhaseVariant(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
