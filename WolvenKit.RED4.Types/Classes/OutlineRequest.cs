using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OutlineRequest : IScriptable
	{
		private CName _requester;
		private CBool _shouldAdd;
		private CFloat _outlineDuration;
		private OutlineData _outlineData;

		[Ordinal(0)] 
		[RED("requester")] 
		public CName Requester
		{
			get => GetProperty(ref _requester);
			set => SetProperty(ref _requester, value);
		}

		[Ordinal(1)] 
		[RED("shouldAdd")] 
		public CBool ShouldAdd
		{
			get => GetProperty(ref _shouldAdd);
			set => SetProperty(ref _shouldAdd, value);
		}

		[Ordinal(2)] 
		[RED("outlineDuration")] 
		public CFloat OutlineDuration
		{
			get => GetProperty(ref _outlineDuration);
			set => SetProperty(ref _outlineDuration, value);
		}

		[Ordinal(3)] 
		[RED("outlineData")] 
		public OutlineData OutlineData
		{
			get => GetProperty(ref _outlineData);
			set => SetProperty(ref _outlineData, value);
		}
	}
}
