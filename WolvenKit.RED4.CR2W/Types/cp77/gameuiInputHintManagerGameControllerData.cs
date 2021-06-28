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
			get => GetProperty(ref _inputHintsData);
			set => SetProperty(ref _inputHintsData, value);
		}

		public gameuiInputHintManagerGameControllerData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
