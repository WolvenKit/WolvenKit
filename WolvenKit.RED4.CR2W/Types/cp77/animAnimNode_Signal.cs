using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Signal : animAnimNode_FloatValue
	{
		private CFloat _blendIn;
		private CFloat _blendOut;
		private CName _startEvent;
		private CName _endEvent;
		private CBool _defaultState;
		private CFloat _cooldown;

		[Ordinal(11)] 
		[RED("blendIn")] 
		public CFloat BlendIn
		{
			get => GetProperty(ref _blendIn);
			set => SetProperty(ref _blendIn, value);
		}

		[Ordinal(12)] 
		[RED("blendOut")] 
		public CFloat BlendOut
		{
			get => GetProperty(ref _blendOut);
			set => SetProperty(ref _blendOut, value);
		}

		[Ordinal(13)] 
		[RED("startEvent")] 
		public CName StartEvent
		{
			get => GetProperty(ref _startEvent);
			set => SetProperty(ref _startEvent, value);
		}

		[Ordinal(14)] 
		[RED("endEvent")] 
		public CName EndEvent
		{
			get => GetProperty(ref _endEvent);
			set => SetProperty(ref _endEvent, value);
		}

		[Ordinal(15)] 
		[RED("defaultState")] 
		public CBool DefaultState
		{
			get => GetProperty(ref _defaultState);
			set => SetProperty(ref _defaultState, value);
		}

		[Ordinal(16)] 
		[RED("cooldown")] 
		public CFloat Cooldown
		{
			get => GetProperty(ref _cooldown);
			set => SetProperty(ref _cooldown, value);
		}

		public animAnimNode_Signal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
