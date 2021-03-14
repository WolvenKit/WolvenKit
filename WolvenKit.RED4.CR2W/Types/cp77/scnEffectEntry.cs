using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnEffectEntry : CVariable
	{
		private scnEffectInstanceId _effectInstanceId;
		private CName _effectName;

		[Ordinal(0)] 
		[RED("effectInstanceId")] 
		public scnEffectInstanceId EffectInstanceId
		{
			get
			{
				if (_effectInstanceId == null)
				{
					_effectInstanceId = (scnEffectInstanceId) CR2WTypeManager.Create("scnEffectInstanceId", "effectInstanceId", cr2w, this);
				}
				return _effectInstanceId;
			}
			set
			{
				if (_effectInstanceId == value)
				{
					return;
				}
				_effectInstanceId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("effectName")] 
		public CName EffectName
		{
			get
			{
				if (_effectName == null)
				{
					_effectName = (CName) CR2WTypeManager.Create("CName", "effectName", cr2w, this);
				}
				return _effectName;
			}
			set
			{
				if (_effectName == value)
				{
					return;
				}
				_effectName = value;
				PropertySet(this);
			}
		}

		public scnEffectEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
