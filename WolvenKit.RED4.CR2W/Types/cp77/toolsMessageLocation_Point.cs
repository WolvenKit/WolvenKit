using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class toolsMessageLocation_Point : toolsIMessageLocation
	{
		private MessageResourcePath _resourcePath;
		private Vector3 _point;

		[Ordinal(0)] 
		[RED("resourcePath")] 
		public MessageResourcePath ResourcePath
		{
			get => GetProperty(ref _resourcePath);
			set => SetProperty(ref _resourcePath, value);
		}

		[Ordinal(1)] 
		[RED("point")] 
		public Vector3 Point
		{
			get => GetProperty(ref _point);
			set => SetProperty(ref _point, value);
		}

		public toolsMessageLocation_Point(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
