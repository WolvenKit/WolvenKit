using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SToggleOperationData : CVariable
	{
		private CInt32 _index;
		private CBool _enable;
		private CEnum<EOperationClassType> _classType;

		[Ordinal(0)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetProperty(ref _index);
			set => SetProperty(ref _index, value);
		}

		[Ordinal(1)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetProperty(ref _enable);
			set => SetProperty(ref _enable, value);
		}

		[Ordinal(2)] 
		[RED("classType")] 
		public CEnum<EOperationClassType> ClassType
		{
			get => GetProperty(ref _classType);
			set => SetProperty(ref _classType, value);
		}

		public SToggleOperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
