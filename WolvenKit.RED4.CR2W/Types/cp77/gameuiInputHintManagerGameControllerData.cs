using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiInputHintManagerGameControllerData : gameuiBaseUIData
	{
		private CArray<gameuiInputHintData> _inputHintsData;

		[Ordinal(1)] 
		[RED("inputHintsData")] 
		public CArray<gameuiInputHintData> InputHintsData
		{
			get
			{
				if (_inputHintsData == null)
				{
					_inputHintsData = (CArray<gameuiInputHintData>) CR2WTypeManager.Create("array:gameuiInputHintData", "inputHintsData", cr2w, this);
				}
				return _inputHintsData;
			}
			set
			{
				if (_inputHintsData == value)
				{
					return;
				}
				_inputHintsData = value;
				PropertySet(this);
			}
		}

		public gameuiInputHintManagerGameControllerData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
