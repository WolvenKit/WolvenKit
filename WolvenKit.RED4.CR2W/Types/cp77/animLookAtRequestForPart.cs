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
			get
			{
				if (_bodyPart == null)
				{
					_bodyPart = (CName) CR2WTypeManager.Create("CName", "bodyPart", cr2w, this);
				}
				return _bodyPart;
			}
			set
			{
				if (_bodyPart == value)
				{
					return;
				}
				_bodyPart = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("request")] 
		public animLookAtRequest Request
		{
			get
			{
				if (_request == null)
				{
					_request = (animLookAtRequest) CR2WTypeManager.Create("animLookAtRequest", "request", cr2w, this);
				}
				return _request;
			}
			set
			{
				if (_request == value)
				{
					return;
				}
				_request = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("attachLeftHandToRightHand")] 
		public CInt32 AttachLeftHandToRightHand
		{
			get
			{
				if (_attachLeftHandToRightHand == null)
				{
					_attachLeftHandToRightHand = (CInt32) CR2WTypeManager.Create("Int32", "attachLeftHandToRightHand", cr2w, this);
				}
				return _attachLeftHandToRightHand;
			}
			set
			{
				if (_attachLeftHandToRightHand == value)
				{
					return;
				}
				_attachLeftHandToRightHand = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("attachRightHandToLeftHand")] 
		public CInt32 AttachRightHandToLeftHand
		{
			get
			{
				if (_attachRightHandToLeftHand == null)
				{
					_attachRightHandToLeftHand = (CInt32) CR2WTypeManager.Create("Int32", "attachRightHandToLeftHand", cr2w, this);
				}
				return _attachRightHandToLeftHand;
			}
			set
			{
				if (_attachRightHandToLeftHand == value)
				{
					return;
				}
				_attachRightHandToLeftHand = value;
				PropertySet(this);
			}
		}

		public animLookAtRequestForPart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
