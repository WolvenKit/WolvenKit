using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CommandSignal : gameTaggedSignalUserData
	{
		private CBool _track;
		private CArray<CName> _commandClassNames;

		[Ordinal(1)] 
		[RED("track")] 
		public CBool Track
		{
			get
			{
				if (_track == null)
				{
					_track = (CBool) CR2WTypeManager.Create("Bool", "track", cr2w, this);
				}
				return _track;
			}
			set
			{
				if (_track == value)
				{
					return;
				}
				_track = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("commandClassNames")] 
		public CArray<CName> CommandClassNames
		{
			get
			{
				if (_commandClassNames == null)
				{
					_commandClassNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "commandClassNames", cr2w, this);
				}
				return _commandClassNames;
			}
			set
			{
				if (_commandClassNames == value)
				{
					return;
				}
				_commandClassNames = value;
				PropertySet(this);
			}
		}

		public CommandSignal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
