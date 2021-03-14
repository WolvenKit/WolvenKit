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
			get
			{
				if (_audioTag == null)
				{
					_audioTag = (CName) CR2WTypeManager.Create("CName", "audioTag", cr2w, this);
				}
				return _audioTag;
			}
			set
			{
				if (_audioTag == value)
				{
					return;
				}
				_audioTag = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get
			{
				if (_radius == null)
				{
					_radius = (CFloat) CR2WTypeManager.Create("Float", "radius", cr2w, this);
				}
				return _radius;
			}
			set
			{
				if (_radius == value)
				{
					return;
				}
				_radius = value;
				PropertySet(this);
			}
		}

		public worldAudioTagNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
