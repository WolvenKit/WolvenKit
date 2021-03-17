using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldAudioTagNode : worldNode
	{
		private CName _audioTag;
		private CFloat _radius;

		[Ordinal(4)] 
		[RED("audioTag")] 
		public CName AudioTag
		{
			get => GetProperty(ref _audioTag);
			set => SetProperty(ref _audioTag, value);
		}

		[Ordinal(5)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetProperty(ref _radius);
			set => SetProperty(ref _radius, value);
		}

		public worldAudioTagNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
