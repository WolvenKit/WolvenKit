using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleGridDestructionEvent : redEvent
	{
		private CArrayFixedSize<CFloat> _state;
		private CArrayFixedSize<CFloat> _rawChange;
		private CArrayFixedSize<CFloat> _desiredChange;

		[Ordinal(0)] 
		[RED("state", 16)] 
		public CArrayFixedSize<CFloat> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(1)] 
		[RED("rawChange", 16)] 
		public CArrayFixedSize<CFloat> RawChange
		{
			get => GetProperty(ref _rawChange);
			set => SetProperty(ref _rawChange, value);
		}

		[Ordinal(2)] 
		[RED("desiredChange", 16)] 
		public CArrayFixedSize<CFloat> DesiredChange
		{
			get => GetProperty(ref _desiredChange);
			set => SetProperty(ref _desiredChange, value);
		}

		public vehicleGridDestructionEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
