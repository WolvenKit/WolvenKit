using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnIKEventData : CVariable
	{
		private Quaternion _orientation;
		private scnAnimTargetBasicData _basic;
		private CName _chainName;
		private animIKTargetRequest _request;

		[Ordinal(0)] 
		[RED("orientation")] 
		public Quaternion Orientation
		{
			get
			{
				if (_orientation == null)
				{
					_orientation = (Quaternion) CR2WTypeManager.Create("Quaternion", "orientation", cr2w, this);
				}
				return _orientation;
			}
			set
			{
				if (_orientation == value)
				{
					return;
				}
				_orientation = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("basic")] 
		public scnAnimTargetBasicData Basic
		{
			get
			{
				if (_basic == null)
				{
					_basic = (scnAnimTargetBasicData) CR2WTypeManager.Create("scnAnimTargetBasicData", "basic", cr2w, this);
				}
				return _basic;
			}
			set
			{
				if (_basic == value)
				{
					return;
				}
				_basic = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("chainName")] 
		public CName ChainName
		{
			get
			{
				if (_chainName == null)
				{
					_chainName = (CName) CR2WTypeManager.Create("CName", "chainName", cr2w, this);
				}
				return _chainName;
			}
			set
			{
				if (_chainName == value)
				{
					return;
				}
				_chainName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		public scnIKEventData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
