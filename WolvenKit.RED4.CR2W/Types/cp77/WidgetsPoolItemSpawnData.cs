using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WidgetsPoolItemSpawnData : IScriptable
	{
		private CInt32 _index;
		private CInt32 _requestVersion;

		[Ordinal(0)] 
		[RED("index")] 
		public CInt32 Index
		{
			get
			{
				if (_index == null)
				{
					_index = (CInt32) CR2WTypeManager.Create("Int32", "index", cr2w, this);
				}
				return _index;
			}
			set
			{
				if (_index == value)
				{
					return;
				}
				_index = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("requestVersion")] 
		public CInt32 RequestVersion
		{
			get
			{
				if (_requestVersion == null)
				{
					_requestVersion = (CInt32) CR2WTypeManager.Create("Int32", "requestVersion", cr2w, this);
				}
				return _requestVersion;
			}
			set
			{
				if (_requestVersion == value)
				{
					return;
				}
				_requestVersion = value;
				PropertySet(this);
			}
		}

		public WidgetsPoolItemSpawnData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
