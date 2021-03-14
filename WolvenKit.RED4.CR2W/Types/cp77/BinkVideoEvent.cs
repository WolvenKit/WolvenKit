using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BinkVideoEvent : redEvent
	{
		private redResourceReferenceScriptToken _path;
		private CFloat _startingTime;
		private CBool _shouldPlay;

		[Ordinal(0)] 
		[RED("path")] 
		public redResourceReferenceScriptToken Path
		{
			get
			{
				if (_path == null)
				{
					_path = (redResourceReferenceScriptToken) CR2WTypeManager.Create("redResourceReferenceScriptToken", "path", cr2w, this);
				}
				return _path;
			}
			set
			{
				if (_path == value)
				{
					return;
				}
				_path = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("startingTime")] 
		public CFloat StartingTime
		{
			get
			{
				if (_startingTime == null)
				{
					_startingTime = (CFloat) CR2WTypeManager.Create("Float", "startingTime", cr2w, this);
				}
				return _startingTime;
			}
			set
			{
				if (_startingTime == value)
				{
					return;
				}
				_startingTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("shouldPlay")] 
		public CBool ShouldPlay
		{
			get
			{
				if (_shouldPlay == null)
				{
					_shouldPlay = (CBool) CR2WTypeManager.Create("Bool", "shouldPlay", cr2w, this);
				}
				return _shouldPlay;
			}
			set
			{
				if (_shouldPlay == value)
				{
					return;
				}
				_shouldPlay = value;
				PropertySet(this);
			}
		}

		public BinkVideoEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
