using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entLookAtAddEvent : entAnimTargetAddEvent
	{
		private animLookAtRef _outLookAtRef;
		private animLookAtRequest _request;

		[Ordinal(2)] 
		[RED("outLookAtRef")] 
		public animLookAtRef OutLookAtRef
		{
			get
			{
				if (_outLookAtRef == null)
				{
					_outLookAtRef = (animLookAtRef) CR2WTypeManager.Create("animLookAtRef", "outLookAtRef", cr2w, this);
				}
				return _outLookAtRef;
			}
			set
			{
				if (_outLookAtRef == value)
				{
					return;
				}
				_outLookAtRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		public entLookAtAddEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
