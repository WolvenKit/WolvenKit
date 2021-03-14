using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class navLocomotionPathPointUserDataEntry : CVariable
	{
		private CHandle<navLocomotionPathPointUserData> _userData;
		private CUInt32 _nextUserData;

		[Ordinal(0)] 
		[RED("userData")] 
		public CHandle<navLocomotionPathPointUserData> UserData
		{
			get
			{
				if (_userData == null)
				{
					_userData = (CHandle<navLocomotionPathPointUserData>) CR2WTypeManager.Create("handle:navLocomotionPathPointUserData", "userData", cr2w, this);
				}
				return _userData;
			}
			set
			{
				if (_userData == value)
				{
					return;
				}
				_userData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("nextUserData")] 
		public CUInt32 NextUserData
		{
			get
			{
				if (_nextUserData == null)
				{
					_nextUserData = (CUInt32) CR2WTypeManager.Create("Uint32", "nextUserData", cr2w, this);
				}
				return _nextUserData;
			}
			set
			{
				if (_nextUserData == value)
				{
					return;
				}
				_nextUserData = value;
				PropertySet(this);
			}
		}

		public navLocomotionPathPointUserDataEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
