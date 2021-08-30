using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animLookAtRequestForPart : RedBaseClass
	{
		private CName _bodyPart;
		private animLookAtRequest _request;
		private CInt32 _attachLeftHandToRightHand;
		private CInt32 _attachRightHandToLeftHand;

		[Ordinal(0)] 
		[RED("bodyPart")] 
		public CName BodyPart
		{
			get => GetProperty(ref _bodyPart);
			set => SetProperty(ref _bodyPart, value);
		}

		[Ordinal(1)] 
		[RED("request")] 
		public animLookAtRequest Request
		{
			get => GetProperty(ref _request);
			set => SetProperty(ref _request, value);
		}

		[Ordinal(2)] 
		[RED("attachLeftHandToRightHand")] 
		public CInt32 AttachLeftHandToRightHand
		{
			get => GetProperty(ref _attachLeftHandToRightHand);
			set => SetProperty(ref _attachLeftHandToRightHand, value);
		}

		[Ordinal(3)] 
		[RED("attachRightHandToLeftHand")] 
		public CInt32 AttachRightHandToLeftHand
		{
			get => GetProperty(ref _attachRightHandToLeftHand);
			set => SetProperty(ref _attachRightHandToLeftHand, value);
		}

		public animLookAtRequestForPart()
		{
			_bodyPart = "Eyes";
			_attachLeftHandToRightHand = -1;
			_attachRightHandToLeftHand = -1;
		}
	}
}
