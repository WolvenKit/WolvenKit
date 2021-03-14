using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldCommunityEntryInitialState : CVariable
	{
		private CName _entryName;
		private CName _initialPhaseName;
		private CBool _entryActiveOnStart;

		[Ordinal(0)] 
		[RED("entryName")] 
		public CName EntryName
		{
			get
			{
				if (_entryName == null)
				{
					_entryName = (CName) CR2WTypeManager.Create("CName", "entryName", cr2w, this);
				}
				return _entryName;
			}
			set
			{
				if (_entryName == value)
				{
					return;
				}
				_entryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("initialPhaseName")] 
		public CName InitialPhaseName
		{
			get
			{
				if (_initialPhaseName == null)
				{
					_initialPhaseName = (CName) CR2WTypeManager.Create("CName", "initialPhaseName", cr2w, this);
				}
				return _initialPhaseName;
			}
			set
			{
				if (_initialPhaseName == value)
				{
					return;
				}
				_initialPhaseName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("entryActiveOnStart")] 
		public CBool EntryActiveOnStart
		{
			get
			{
				if (_entryActiveOnStart == null)
				{
					_entryActiveOnStart = (CBool) CR2WTypeManager.Create("Bool", "entryActiveOnStart", cr2w, this);
				}
				return _entryActiveOnStart;
			}
			set
			{
				if (_entryActiveOnStart == value)
				{
					return;
				}
				_entryActiveOnStart = value;
				PropertySet(this);
			}
		}

		public worldCommunityEntryInitialState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
