using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entReplicatedLookAtAdd : entReplicatedLookAtData
	{
		private CName _bodyPart;
		private animLookAtRequest _request;
		private CHandle<entIPositionProvider> _targetPositionProvider;
		private animLookAtRef _ref;

		[Ordinal(1)] 
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

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("targetPositionProvider")] 
		public CHandle<entIPositionProvider> TargetPositionProvider
		{
			get
			{
				if (_targetPositionProvider == null)
				{
					_targetPositionProvider = (CHandle<entIPositionProvider>) CR2WTypeManager.Create("handle:entIPositionProvider", "targetPositionProvider", cr2w, this);
				}
				return _targetPositionProvider;
			}
			set
			{
				if (_targetPositionProvider == value)
				{
					return;
				}
				_targetPositionProvider = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("ref")] 
		public animLookAtRef Ref
		{
			get
			{
				if (_ref == null)
				{
					_ref = (animLookAtRef) CR2WTypeManager.Create("animLookAtRef", "ref", cr2w, this);
				}
				return _ref;
			}
			set
			{
				if (_ref == value)
				{
					return;
				}
				_ref = value;
				PropertySet(this);
			}
		}

		public entReplicatedLookAtAdd(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
