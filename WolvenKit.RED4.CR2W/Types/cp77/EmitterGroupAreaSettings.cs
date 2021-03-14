using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EmitterGroupAreaSettings : IAreaSettings
	{
		private CArray<EmitterGroupParams> _emitterGroupParams_72;
		private CArray<EmitterGroupAreaParams> _emitterGroupParams_88;

		[Ordinal(2)] 
		[RED("emitterGroupParams")] 
		public CArray<EmitterGroupParams> EmitterGroupParams_72
		{
			get
			{
				if (_emitterGroupParams_72 == null)
				{
                    _emitterGroupParams_72 = (CArray<EmitterGroupParams>) CR2WTypeManager.Create("array:EmitterGroupParams", "emitterGroupParams", cr2w, this);
				}
				return _emitterGroupParams_72;
			}
			set
			{
				if (_emitterGroupParams_72 == value)
				{
					return;
				}
                _emitterGroupParams_72 = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("EmitterGroupParams")] 
		public CArray<EmitterGroupAreaParams> EmitterGroupParams_88
		{
			get
			{
				if (_emitterGroupParams_88 == null)
				{
                    _emitterGroupParams_88 = (CArray<EmitterGroupAreaParams>) CR2WTypeManager.Create("array:EmitterGroupAreaParams", "EmitterGroupParams", cr2w, this);
				}
				return _emitterGroupParams_88;
			}
			set
			{
				if (_emitterGroupParams_88 == value)
				{
					return;
				}
                _emitterGroupParams_88 = value;
				PropertySet(this);
			}
		}

		public EmitterGroupAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
