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
			get => GetProperty(ref _userData);
			set => SetProperty(ref _userData, value);
		}

		[Ordinal(1)] 
		[RED("nextUserData")] 
		public CUInt32 NextUserData
		{
			get => GetProperty(ref _nextUserData);
			set => SetProperty(ref _nextUserData, value);
		}

		public navLocomotionPathPointUserDataEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
