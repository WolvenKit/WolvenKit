using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiBraindanceClueDescriptor : CVariable
	{
		private CEnum<gameuiEClueDescriptorMode> _mode;
		private CEnum<gameuiEBraindanceLayer> _layer;
		private CFloat _startTime;
		private CFloat _endTime;
		private CName _clueName;

		[Ordinal(0)] 
		[RED("mode")] 
		public CEnum<gameuiEClueDescriptorMode> Mode
		{
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}

		[Ordinal(1)] 
		[RED("layer")] 
		public CEnum<gameuiEBraindanceLayer> Layer
		{
			get => GetProperty(ref _layer);
			set => SetProperty(ref _layer, value);
		}

		[Ordinal(2)] 
		[RED("startTime")] 
		public CFloat StartTime
		{
			get => GetProperty(ref _startTime);
			set => SetProperty(ref _startTime, value);
		}

		[Ordinal(3)] 
		[RED("endTime")] 
		public CFloat EndTime
		{
			get => GetProperty(ref _endTime);
			set => SetProperty(ref _endTime, value);
		}

		[Ordinal(4)] 
		[RED("clueName")] 
		public CName ClueName
		{
			get => GetProperty(ref _clueName);
			set => SetProperty(ref _clueName, value);
		}

		public gameuiBraindanceClueDescriptor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
