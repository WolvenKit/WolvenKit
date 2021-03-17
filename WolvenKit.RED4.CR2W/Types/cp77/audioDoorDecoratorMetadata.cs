using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioDoorDecoratorMetadata : audioEmitterMetadata
	{
		private CName _startOpen;
		private CName _startClose;
		private CName _endOpen;
		private CName _endClose;
		private CName _openLoop;
		private CName _closeLoop;
		private CFloat _openTime;
		private CFloat _closeTime;

		[Ordinal(1)] 
		[RED("startOpen")] 
		public CName StartOpen
		{
			get => GetProperty(ref _startOpen);
			set => SetProperty(ref _startOpen, value);
		}

		[Ordinal(2)] 
		[RED("startClose")] 
		public CName StartClose
		{
			get => GetProperty(ref _startClose);
			set => SetProperty(ref _startClose, value);
		}

		[Ordinal(3)] 
		[RED("endOpen")] 
		public CName EndOpen
		{
			get => GetProperty(ref _endOpen);
			set => SetProperty(ref _endOpen, value);
		}

		[Ordinal(4)] 
		[RED("endClose")] 
		public CName EndClose
		{
			get => GetProperty(ref _endClose);
			set => SetProperty(ref _endClose, value);
		}

		[Ordinal(5)] 
		[RED("openLoop")] 
		public CName OpenLoop
		{
			get => GetProperty(ref _openLoop);
			set => SetProperty(ref _openLoop, value);
		}

		[Ordinal(6)] 
		[RED("closeLoop")] 
		public CName CloseLoop
		{
			get => GetProperty(ref _closeLoop);
			set => SetProperty(ref _closeLoop, value);
		}

		[Ordinal(7)] 
		[RED("openTime")] 
		public CFloat OpenTime
		{
			get => GetProperty(ref _openTime);
			set => SetProperty(ref _openTime, value);
		}

		[Ordinal(8)] 
		[RED("closeTime")] 
		public CFloat CloseTime
		{
			get => GetProperty(ref _closeTime);
			set => SetProperty(ref _closeTime, value);
		}

		public audioDoorDecoratorMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
