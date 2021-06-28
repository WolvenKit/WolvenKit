using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class toolsMessageLocation_BoundingBox : toolsIMessageLocation
	{
		private MessageResourcePath _resourcePath;
		private Box _box;

		[Ordinal(0)] 
		[RED("resourcePath")] 
		public MessageResourcePath ResourcePath
		{
			get => GetProperty(ref _resourcePath);
			set => SetProperty(ref _resourcePath, value);
		}

		[Ordinal(1)] 
		[RED("box")] 
		public Box Box
		{
			get => GetProperty(ref _box);
			set => SetProperty(ref _box, value);
		}

		public toolsMessageLocation_BoundingBox(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
