using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVoiceContextMap : audioAudioMetadata
	{
		private CArray<CName> _includes;
		private CArray<audioVoiceContextMapItem> _contexts;

		[Ordinal(1)] 
		[RED("includes")] 
		public CArray<CName> Includes
		{
			get
			{
				if (_includes == null)
				{
					_includes = (CArray<CName>) CR2WTypeManager.Create("array:CName", "includes", cr2w, this);
				}
				return _includes;
			}
			set
			{
				if (_includes == value)
				{
					return;
				}
				_includes = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("contexts")] 
		public CArray<audioVoiceContextMapItem> Contexts
		{
			get
			{
				if (_contexts == null)
				{
					_contexts = (CArray<audioVoiceContextMapItem>) CR2WTypeManager.Create("array:audioVoiceContextMapItem", "contexts", cr2w, this);
				}
				return _contexts;
			}
			set
			{
				if (_contexts == value)
				{
					return;
				}
				_contexts = value;
				PropertySet(this);
			}
		}

		public audioVoiceContextMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
