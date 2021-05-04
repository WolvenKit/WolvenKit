using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animLookAtRequestForPart : CVariable
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

		public animLookAtRequestForPart(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
