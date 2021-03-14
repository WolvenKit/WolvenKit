using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPauseTime_NodeType : questITimeManagerNodeType
	{
		private CBool _pause;
		private CName _source;

		[Ordinal(0)] 
		[RED("pause")] 
		public CBool Pause
		{
			get
			{
				if (_pause == null)
				{
					_pause = (CBool) CR2WTypeManager.Create("Bool", "pause", cr2w, this);
				}
				return _pause;
			}
			set
			{
				if (_pause == value)
				{
					return;
				}
				_pause = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("source")] 
		public CName Source
		{
			get
			{
				if (_source == null)
				{
					_source = (CName) CR2WTypeManager.Create("CName", "source", cr2w, this);
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

		public questPauseTime_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
