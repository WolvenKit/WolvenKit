using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldITriggerAreaNotifer : IScriptable
	{
		private CBool _isEnabled;
		private CEnum<TriggerChannel> _includeChannels;
		private CUInt32 _excludeChannels;

		[Ordinal(0)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("includeChannels")] 
		public CEnum<TriggerChannel> IncludeChannels
		{
			get
			{
				if (_includeChannels == null)
				{
					_includeChannels = (CEnum<TriggerChannel>) CR2WTypeManager.Create("TriggerChannel", "includeChannels", cr2w, this);
				}
				return _includeChannels;
			}
			set
			{
				if (_includeChannels == value)
				{
					return;
				}
				_includeChannels = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("excludeChannels")] 
		public CUInt32 ExcludeChannels
		{
			get
			{
				if (_excludeChannels == null)
				{
					_excludeChannels = (CUInt32) CR2WTypeManager.Create("Uint32", "excludeChannels", cr2w, this);
				}
				return _excludeChannels;
			}
			set
			{
				if (_excludeChannels == value)
				{
					return;
				}
				_excludeChannels = value;
				PropertySet(this);
			}
		}

		public worldITriggerAreaNotifer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
