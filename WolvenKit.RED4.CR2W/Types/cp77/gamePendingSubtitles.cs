using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePendingSubtitles : CVariable
	{
		private CArray<scnDialogLineData> _pendingSubtitles;

		[Ordinal(0)] 
		[RED("pendingSubtitles")] 
		public CArray<scnDialogLineData> PendingSubtitles
		{
			get
			{
				if (_pendingSubtitles == null)
				{
					_pendingSubtitles = (CArray<scnDialogLineData>) CR2WTypeManager.Create("array:scnDialogLineData", "pendingSubtitles", cr2w, this);
				}
				return _pendingSubtitles;
			}
			set
			{
				if (_pendingSubtitles == value)
				{
					return;
				}
				_pendingSubtitles = value;
				PropertySet(this);
			}
		}

		public gamePendingSubtitles(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
