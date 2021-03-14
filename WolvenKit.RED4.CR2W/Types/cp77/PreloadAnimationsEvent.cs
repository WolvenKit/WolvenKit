using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreloadAnimationsEvent : redEvent
	{
		private CName _streamingContextName;
		private CBool _highPriority;

		[Ordinal(0)] 
		[RED("streamingContextName")] 
		public CName StreamingContextName
		{
			get
			{
				if (_streamingContextName == null)
				{
					_streamingContextName = (CName) CR2WTypeManager.Create("CName", "streamingContextName", cr2w, this);
				}
				return _streamingContextName;
			}
			set
			{
				if (_streamingContextName == value)
				{
					return;
				}
				_streamingContextName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("highPriority")] 
		public CBool HighPriority
		{
			get
			{
				if (_highPriority == null)
				{
					_highPriority = (CBool) CR2WTypeManager.Create("Bool", "highPriority", cr2w, this);
				}
				return _highPriority;
			}
			set
			{
				if (_highPriority == value)
				{
					return;
				}
				_highPriority = value;
				PropertySet(this);
			}
		}

		public PreloadAnimationsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
