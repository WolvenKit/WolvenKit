using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
    [REDMeta]
    public class toolsTimeLineBaseDescriptor : CVariable
    {
        [Ordinal(0)] [RED("tracks")] public toolsTimeLineItemCollection tracks { get; set; }
        [Ordinal(1)] [RED("events")] public toolsTimeLineItemCollection events { get; set; }
        [Ordinal(2)] [RED("lastUsedId")] public CUInt64 lastUsedId { get; set; }
        [Ordinal(3)] [RED("tracksRootId")] public CUInt64 tracksRootId { get; set; }

        public toolsTimeLineBaseDescriptor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

	[REDMeta]
	public class toolsTimeLineItemCollection : CVariable
	{
        [Ordinal(0)] [RED("items")] public CArray<CHandle<toolsTimeLineItemDescription>> items { get; set; }

		public toolsTimeLineItemCollection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

	[REDMeta]
	public class toolsTimeLineItemDescription : CVariable
	{
		

        public toolsTimeLineItemDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

	[REDMeta]
	public class toolsAnimTimelineEvent : toolsTimeLineTrackBaseItem
    {
        //[Ordinal(0)] [RED("id")] public CUInt64 id { get; set; }
        //[Ordinal(1)] [RED("type")] public CString type { get; set; }

        [Ordinal(0)] [RED("trackId")] public CUInt64 trackId { get; set; }
        [Ordinal(1)] [RED("startTime")] public CFloat startTime { get; set; }
        [Ordinal(2)] [RED("runtimeEvent")] public CHandle<animAnimEvent> runtimeEvent { get; set; }

        public toolsAnimTimelineEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

	

	[REDMeta]
	public class toolsTimeLineTrackBaseItem : CVariable
	{
        [Ordinal(0)] [RED("id")] public CUInt64 id { get; set; }
        [Ordinal(1)] [RED("type")] public CString type { get; set; }
        [Ordinal(2)] [RED("visualType")] public CString visualType { get; set; }
        [Ordinal(3)] [RED("caption")] public CString caption { get; set; }
        [Ordinal(4)] [RED("parentId")] public CUInt64 parentId { get; set; }
        [Ordinal(5)] [RED("children")] public CArray<CUInt64> children { get; set; }
        
        public toolsTimeLineTrackBaseItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
