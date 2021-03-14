using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnLookAtAdvancedEventData : CVariable
	{
		private scnAnimTargetBasicData _basic;
		private CArray<animLookAtRequestForPart> _requests;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("requests")] 
		public CArray<animLookAtRequestForPart> Requests
		{
			get
			{
				if (_requests == null)
				{
					_requests = (CArray<animLookAtRequestForPart>) CR2WTypeManager.Create("array:animLookAtRequestForPart", "requests", cr2w, this);
				}
				return _requests;
			}
			set
			{
				if (_requests == value)
				{
					return;
				}
				_requests = value;
				PropertySet(this);
			}
		}

		public scnLookAtAdvancedEventData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
