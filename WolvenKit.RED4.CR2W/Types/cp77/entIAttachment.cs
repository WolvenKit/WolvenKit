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
			get => GetProperty(ref _source);
			set => SetProperty(ref _source, value);
		}

		[Ordinal(1)] 
		[RED("destination")] 
		public wCHandle<entIComponent> Destination
		{
			get => GetProperty(ref _destination);
			set => SetProperty(ref _destination, value);
		}

		public entIAttachment(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
