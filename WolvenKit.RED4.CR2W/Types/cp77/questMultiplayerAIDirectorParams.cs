using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questMultiplayerAIDirectorParams : ISerializable
	{
		private CEnum<questMultiplayerAIDirectorFunction> _function;
		private CEnum<questMultiplayerAIDirectorStatus> _status;
		private NodeRef _pathRef;
		private CString _scheduleEntryName;
		private CString _scheduleName;

		[Ordinal(0)] 
		[RED("function")] 
		public CEnum<questMultiplayerAIDirectorFunction> Function
		{
			get => GetProperty(ref _function);
			set => SetProperty(ref _function, value);
		}

		[Ordinal(1)] 
		[RED("status")] 
		public CEnum<questMultiplayerAIDirectorStatus> Status
		{
			get => GetProperty(ref _status);
			set => SetProperty(ref _status, value);
		}

		[Ordinal(2)] 
		[RED("pathRef")] 
		public NodeRef PathRef
		{
			get => GetProperty(ref _pathRef);
			set => SetProperty(ref _pathRef, value);
		}

		[Ordinal(3)] 
		[RED("scheduleEntryName")] 
		public CString ScheduleEntryName
		{
			get => GetProperty(ref _scheduleEntryName);
			set => SetProperty(ref _scheduleEntryName, value);
		}

		[Ordinal(4)] 
		[RED("scheduleName")] 
		public CString ScheduleName
		{
			get => GetProperty(ref _scheduleName);
			set => SetProperty(ref _scheduleName, value);
		}

		public questMultiplayerAIDirectorParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
