using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldWorldListResourceEntry : CVariable
	{
		private raRef<CResource> _world;
		private raRef<CResource> _streamingWorld;
		private CString _worldName;

		[Ordinal(0)] 
		[RED("world")] 
		public raRef<CResource> World
		{
			get
			{
				if (_world == null)
				{
					_world = (raRef<CResource>) CR2WTypeManager.Create("raRef:CResource", "world", cr2w, this);
				}
				return _world;
			}
			set
			{
				if (_world == value)
				{
					return;
				}
				_world = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("streamingWorld")] 
		public raRef<CResource> StreamingWorld
		{
			get
			{
				if (_streamingWorld == null)
				{
					_streamingWorld = (raRef<CResource>) CR2WTypeManager.Create("raRef:CResource", "streamingWorld", cr2w, this);
				}
				return _streamingWorld;
			}
			set
			{
				if (_streamingWorld == value)
				{
					return;
				}
				_streamingWorld = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("worldName")] 
		public CString WorldName
		{
			get
			{
				if (_worldName == null)
				{
					_worldName = (CString) CR2WTypeManager.Create("String", "worldName", cr2w, this);
				}
				return _worldName;
			}
			set
			{
				if (_worldName == value)
				{
					return;
				}
				_worldName = value;
				PropertySet(this);
			}
		}

		public worldWorldListResourceEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
