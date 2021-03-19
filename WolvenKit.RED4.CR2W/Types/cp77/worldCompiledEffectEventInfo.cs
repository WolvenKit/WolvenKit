using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldCompiledEffectEventInfo : CVariable
	{
		private CRUID _eventRUID;
		private CUInt64 _placementIndexMask;
		private CUInt64 _componentIndexMask;
		private CUInt8 _flags;

		[Ordinal(0)] 
		[RED("eventRUID")] 
		public CRUID EventRUID
		{
			get => GetProperty(ref _eventRUID);
			set => SetProperty(ref _eventRUID, value);
		}

		[Ordinal(1)] 
		[RED("placementIndexMask")] 
		public CUInt64 PlacementIndexMask
		{
			get => GetProperty(ref _placementIndexMask);
			set => SetProperty(ref _placementIndexMask, value);
		}

		[Ordinal(2)] 
		[RED("componentIndexMask")] 
		public CUInt64 ComponentIndexMask
		{
			get => GetProperty(ref _componentIndexMask);
			set => SetProperty(ref _componentIndexMask, value);
		}

		[Ordinal(3)] 
		[RED("flags")] 
		public CUInt8 Flags
		{
			get => GetProperty(ref _flags);
			set => SetProperty(ref _flags, value);
		}

		public worldCompiledEffectEventInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
