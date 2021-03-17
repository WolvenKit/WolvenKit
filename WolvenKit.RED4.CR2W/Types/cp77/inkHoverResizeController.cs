using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkHoverResizeController : inkWidgetLogicController
	{
		private wCHandle<inkWidget> _root;
		private CHandle<inkanimDefinition> _animToNew;
		private CHandle<inkanimDefinition> _animToOld;
		private Vector2 _vectorNewSize;
		private Vector2 _vectorOldSize;
		private CFloat _animationDuration;

		[Ordinal(1)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(2)] 
		[RED("animToNew")] 
		public CHandle<inkanimDefinition> AnimToNew
		{
			get => GetProperty(ref _animToNew);
			set => SetProperty(ref _animToNew, value);
		}

		[Ordinal(3)] 
		[RED("animToOld")] 
		public CHandle<inkanimDefinition> AnimToOld
		{
			get => GetProperty(ref _animToOld);
			set => SetProperty(ref _animToOld, value);
		}

		[Ordinal(4)] 
		[RED("vectorNewSize")] 
		public Vector2 VectorNewSize
		{
			get => GetProperty(ref _vectorNewSize);
			set => SetProperty(ref _vectorNewSize, value);
		}

		[Ordinal(5)] 
		[RED("vectorOldSize")] 
		public Vector2 VectorOldSize
		{
			get => GetProperty(ref _vectorOldSize);
			set => SetProperty(ref _vectorOldSize, value);
		}

		[Ordinal(6)] 
		[RED("animationDuration")] 
		public CFloat AnimationDuration
		{
			get => GetProperty(ref _animationDuration);
			set => SetProperty(ref _animationDuration, value);
		}

		public inkHoverResizeController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
