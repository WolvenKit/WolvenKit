using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SToggleDeviceOperationData : CVariable
	{
		private CName _operationName;
		private CBool _enable;

		[Ordinal(0)] 
		[RED("operationName")] 
		public CName OperationName
		{
			get => GetProperty(ref _operationName);
			set => SetProperty(ref _operationName, value);
		}

		[Ordinal(1)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetProperty(ref _enable);
			set => SetProperty(ref _enable, value);
		}

		public SToggleDeviceOperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
