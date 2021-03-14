using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entIKTargetAddEvent : entAnimTargetAddEvent
	{
		private animIKTargetRef _outIKTargetRef;
		private CHandle<entIOrientationProvider> _orientationProvider;
		private animIKTargetRequest _request;

		[Ordinal(2)] 
		[RED("outIKTargetRef")] 
		public animIKTargetRef OutIKTargetRef
		{
			get
			{
				if (_outIKTargetRef == null)
				{
					_outIKTargetRef = (animIKTargetRef) CR2WTypeManager.Create("animIKTargetRef", "outIKTargetRef", cr2w, this);
				}
				return _outIKTargetRef;
			}
			set
			{
				if (_outIKTargetRef == value)
				{
					return;
				}
				_outIKTargetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("orientationProvider")] 
		public CHandle<entIOrientationProvider> OrientationProvider
		{
			get
			{
				if (_orientationProvider == null)
				{
					_orientationProvider = (CHandle<entIOrientationProvider>) CR2WTypeManager.Create("handle:entIOrientationProvider", "orientationProvider", cr2w, this);
				}
				return _orientationProvider;
			}
			set
			{
				if (_orientationProvider == value)
				{
					return;
				}
				_orientationProvider = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("request")] 
		public animIKTargetRequest Request
		{
			get
			{
				if (_request == null)
				{
					_request = (animIKTargetRequest) CR2WTypeManager.Create("animIKTargetRequest", "request", cr2w, this);
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

		public entIKTargetAddEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
