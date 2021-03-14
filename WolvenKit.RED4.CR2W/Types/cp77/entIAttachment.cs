using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entIAttachment : ISerializable
	{
		private wCHandle<entIComponent> _source;
		private wCHandle<entIComponent> _destination;

		[Ordinal(0)] 
		[RED("source")] 
		public wCHandle<entIComponent> Source
		{
			get
			{
				if (_source == null)
				{
					_source = (wCHandle<entIComponent>) CR2WTypeManager.Create("whandle:entIComponent", "source", cr2w, this);
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
		public wCHandle<entIComponent> Destination
		{
			get
			{
				if (_destination == null)
				{
					_destination = (wCHandle<entIComponent>) CR2WTypeManager.Create("whandle:entIComponent", "destination", cr2w, this);
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

		public entIAttachment(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
