using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entVertexAnimationMapperEntry : CVariable
	{
		private CStatic<entVertexAnimationMapperSource> _sources;
		private entVertexAnimationMapperDestination _destination;

		[Ordinal(0)] 
		[RED("sources", 4)] 
		public CStatic<entVertexAnimationMapperSource> Sources
		{
			get
			{
				if (_sources == null)
				{
					_sources = (CStatic<entVertexAnimationMapperSource>) CR2WTypeManager.Create("static:4,entVertexAnimationMapperSource", "sources", cr2w, this);
				}
				return _sources;
			}
			set
			{
				if (_sources == value)
				{
					return;
				}
				_sources = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("destination")] 
		public entVertexAnimationMapperDestination Destination
		{
			get
			{
				if (_destination == null)
				{
					_destination = (entVertexAnimationMapperDestination) CR2WTypeManager.Create("entVertexAnimationMapperDestination", "destination", cr2w, this);
				}
				return _destination;
			}
			set
			{
				if (_destination == value)
				{
					return;
				}
				_destination = value;
				PropertySet(this);
			}
		}

		public entVertexAnimationMapperEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
