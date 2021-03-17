using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entRenderHighlightEvent : redEvent
	{
		private CUInt8 _fillIndex;
		private CUInt8 _outlineIndex;
		private CBool _seeThroughWalls;
		private CName _componentName;
		private CFloat _opacity;

		[Ordinal(0)] 
		[RED("fillIndex")] 
		public CUInt8 FillIndex
		{
			get => GetProperty(ref _fillIndex);
			set => SetProperty(ref _fillIndex, value);
		}

		[Ordinal(1)] 
		[RED("outlineIndex")] 
		public CUInt8 OutlineIndex
		{
			get => GetProperty(ref _outlineIndex);
			set => SetProperty(ref _outlineIndex, value);
		}

		[Ordinal(2)] 
		[RED("seeThroughWalls")] 
		public CBool SeeThroughWalls
		{
			get => GetProperty(ref _seeThroughWalls);
			set => SetProperty(ref _seeThroughWalls, value);
		}

		[Ordinal(3)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get => GetProperty(ref _componentName);
			set => SetProperty(ref _componentName, value);
		}

		[Ordinal(4)] 
		[RED("opacity")] 
		public CFloat Opacity
		{
			get => GetProperty(ref _opacity);
			set => SetProperty(ref _opacity, value);
		}

		public entRenderHighlightEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
