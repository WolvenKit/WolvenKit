using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entReplicatedLookAtAdd : entReplicatedLookAtData
	{
		private CName _bodyPart;
		private animLookAtRequest _request;
		private CHandle<entIPositionProvider> _targetPositionProvider;
		private animLookAtRef _ref;

		[Ordinal(1)] 
		[RED("bodyPart")] 
		public CName BodyPart
		{
			get => GetProperty(ref _bodyPart);
			set => SetProperty(ref _bodyPart, value);
		}

		[Ordinal(2)] 
		[RED("request")] 
		public animLookAtRequest Request
		{
			get => GetProperty(ref _request);
			set => SetProperty(ref _request, value);
		}

		[Ordinal(3)] 
		[RED("targetPositionProvider")] 
		public CHandle<entIPositionProvider> TargetPositionProvider
		{
			get => GetProperty(ref _targetPositionProvider);
			set => SetProperty(ref _targetPositionProvider, value);
		}

		[Ordinal(4)] 
		[RED("ref")] 
		public animLookAtRef Ref
		{
			get => GetProperty(ref _ref);
			set => SetProperty(ref _ref, value);
		}

		public entReplicatedLookAtAdd()
		{
			_bodyPart = "Eyes";
		}
	}
}
