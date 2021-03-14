using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkVideoSequenceController : inkWidgetLogicController
	{
		private inkVideoWidgetReference _videoWidget;
		private CArray<inkVideoSequenceEntry> _videoSequence;

		[Ordinal(1)] 
		[RED("videoWidget")] 
		public inkVideoWidgetReference VideoWidget
		{
			get
			{
				if (_videoWidget == null)
				{
					_videoWidget = (inkVideoWidgetReference) CR2WTypeManager.Create("inkVideoWidgetReference", "videoWidget", cr2w, this);
				}
				return _videoWidget;
			}
			set
			{
				if (_videoWidget == value)
				{
					return;
				}
				_videoWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("videoSequence")] 
		public CArray<inkVideoSequenceEntry> VideoSequence
		{
			get
			{
				if (_videoSequence == null)
				{
					_videoSequence = (CArray<inkVideoSequenceEntry>) CR2WTypeManager.Create("array:inkVideoSequenceEntry", "videoSequence", cr2w, this);
				}
				return _videoSequence;
			}
			set
			{
				if (_videoSequence == value)
				{
					return;
				}
				_videoSequence = value;
				PropertySet(this);
			}
		}

		public inkVideoSequenceController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
