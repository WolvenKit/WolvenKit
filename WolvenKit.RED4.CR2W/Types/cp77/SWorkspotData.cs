using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SWorkspotData : CVariable
	{
		private CName _componentName;
		private CBool _freeCamera;
		private CEnum<EWorkspotOperationType> _operationType;

		[Ordinal(0)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get => GetProperty(ref _componentName);
			set => SetProperty(ref _componentName, value);
		}

		[Ordinal(1)] 
		[RED("freeCamera")] 
		public CBool FreeCamera
		{
			get => GetProperty(ref _freeCamera);
			set => SetProperty(ref _freeCamera, value);
		}

		[Ordinal(2)] 
		[RED("operationType")] 
		public CEnum<EWorkspotOperationType> OperationType
		{
			get => GetProperty(ref _operationType);
			set => SetProperty(ref _operationType, value);
		}

		public SWorkspotData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
