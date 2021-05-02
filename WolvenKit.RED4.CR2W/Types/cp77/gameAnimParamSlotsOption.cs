using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAnimParamSlotsOption : CVariable
	{
		private TweakDBID _slotID;
		private CName _paramName;
		private CEnum<entAnimParamSlotFunction> _function;

		[Ordinal(0)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}

		[Ordinal(1)] 
		[RED("paramName")] 
		public CName ParamName
		{
			get => GetProperty(ref _paramName);
			set => SetProperty(ref _paramName, value);
		}

		[Ordinal(2)] 
		[RED("function")] 
		public CEnum<entAnimParamSlotFunction> Function
		{
			get => GetProperty(ref _function);
			set => SetProperty(ref _function, value);
		}

		public gameAnimParamSlotsOption(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
