using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animCurvePathBakerAdvancedUserInput : CVariable
	{
		private CStatic<animCurvePathPartInput> _partsInputs;

		[Ordinal(0)] 
		[RED("partsInputs", 3)] 
		public CStatic<animCurvePathPartInput> PartsInputs
		{
			get
			{
				if (_partsInputs == null)
				{
					_partsInputs = (CStatic<animCurvePathPartInput>) CR2WTypeManager.Create("static:3,animCurvePathPartInput", "partsInputs", cr2w, this);
				}
				return _partsInputs;
			}
			set
			{
				if (_partsInputs == value)
				{
					return;
				}
				_partsInputs = value;
				PropertySet(this);
			}
		}

		public animCurvePathBakerAdvancedUserInput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
