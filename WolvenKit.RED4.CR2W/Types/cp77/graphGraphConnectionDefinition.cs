using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class graphGraphConnectionDefinition : graphIGraphObjectDefinition
	{
		private wCHandle<graphGraphSocketDefinition> _source;
		private wCHandle<graphGraphSocketDefinition> _destination;

		[Ordinal(0)] 
		[RED("source")] 
		public wCHandle<graphGraphSocketDefinition> Source
		{
			get
			{
				if (_source == null)
				{
					_source = (wCHandle<graphGraphSocketDefinition>) CR2WTypeManager.Create("whandle:graphGraphSocketDefinition", "source", cr2w, this);
				}
				return _source;
			}
			set
			{
				if (_source == value)
				{
					return;
				}
				_source = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("destination")] 
		public wCHandle<graphGraphSocketDefinition> Destination
		{
			get
			{
				if (_destination == null)
				{
					_destination = (wCHandle<graphGraphSocketDefinition>) CR2WTypeManager.Create("whandle:graphGraphSocketDefinition", "destination", cr2w, this);
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

		public graphGraphConnectionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
