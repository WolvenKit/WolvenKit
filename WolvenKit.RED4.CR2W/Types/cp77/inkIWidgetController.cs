using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkIWidgetController : IScriptable
	{
		private CName _audioMetadataName;

		[Ordinal(0)] 
		[RED("audioMetadataName")] 
		public CName AudioMetadataName
		{
			get
			{
				if (_audioMetadataName == null)
				{
					_audioMetadataName = (CName) CR2WTypeManager.Create("CName", "audioMetadataName", cr2w, this);
				}
				return _audioMetadataName;
			}
			set
			{
				if (_audioMetadataName == value)
				{
					return;
				}
				_audioMetadataName = value;
				PropertySet(this);
			}
		}

		public inkIWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
