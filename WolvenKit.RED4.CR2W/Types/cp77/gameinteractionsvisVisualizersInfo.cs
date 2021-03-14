using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsvisVisualizersInfo : CVariable
	{
		private CInt32 _activeVisId;
		private CArray<CInt32> _visIds;

		[Ordinal(0)] 
		[RED("activeVisId")] 
		public CInt32 ActiveVisId
		{
			get
			{
				if (_activeVisId == null)
				{
					_activeVisId = (CInt32) CR2WTypeManager.Create("Int32", "activeVisId", cr2w, this);
				}
				return _activeVisId;
			}
			set
			{
				if (_activeVisId == value)
				{
					return;
				}
				_activeVisId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("visIds")] 
		public CArray<CInt32> VisIds
		{
			get
			{
				if (_visIds == null)
				{
					_visIds = (CArray<CInt32>) CR2WTypeManager.Create("array:Int32", "visIds", cr2w, this);
				}
				return _visIds;
			}
			set
			{
				if (_visIds == value)
				{
					return;
				}
				_visIds = value;
				PropertySet(this);
			}
		}

		public gameinteractionsvisVisualizersInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
