using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetTimeDilationEffector : gameEffector
	{
		private wCHandle<gameObject> _owner;
		private CName _reason;
		private CName _easeInCurve;
		private CName _easeOutCurve;
		private CFloat _dilation;
		private CFloat _duration;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("reason")] 
		public CName Reason
		{
			get => GetProperty(ref _reason);
			set => SetProperty(ref _reason, value);
		}

		[Ordinal(2)] 
		[RED("easeInCurve")] 
		public CName EaseInCurve
		{
			get => GetProperty(ref _easeInCurve);
			set => SetProperty(ref _easeInCurve, value);
		}

		[Ordinal(3)] 
		[RED("easeOutCurve")] 
		public CName EaseOutCurve
		{
			get => GetProperty(ref _easeOutCurve);
			set => SetProperty(ref _easeOutCurve, value);
		}

		[Ordinal(4)] 
		[RED("dilation")] 
		public CFloat Dilation
		{
			get => GetProperty(ref _dilation);
			set => SetProperty(ref _dilation, value);
		}

		[Ordinal(5)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		public SetTimeDilationEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
