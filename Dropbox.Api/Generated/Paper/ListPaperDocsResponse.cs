// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Paper
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The list paper docs response object</para>
    /// </summary>
    public class ListPaperDocsResponse
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ListPaperDocsResponse> Encoder = new ListPaperDocsResponseEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ListPaperDocsResponse> Decoder = new ListPaperDocsResponseDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListPaperDocsResponse" />
        /// class.</para>
        /// </summary>
        /// <param name="docIds">The list of Paper doc ids that can be used to access the given
        /// Paper docs or supplied to other API methods. The list is sorted in the order
        /// specified by the initial call to <see
        /// cref="Dropbox.Api.Paper.Routes.PaperUserRoutes.DocsListAsync" />.</param>
        /// <param name="cursor">Pass the cursor into <see
        /// cref="Dropbox.Api.Paper.Routes.PaperUserRoutes.DocsListContinueAsync" /> to
        /// paginate through all files. The cursor preserves all properties as specified in the
        /// original call to <see cref="Dropbox.Api.Paper.Routes.PaperUserRoutes.DocsListAsync"
        /// />.</param>
        /// <param name="hasMore">Will be set to True if a subsequent call with the provided
        /// cursor to <see
        /// cref="Dropbox.Api.Paper.Routes.PaperUserRoutes.DocsListContinueAsync" /> returns
        /// immediately with some results. If set to False please allow some delay before
        /// making another call to <see
        /// cref="Dropbox.Api.Paper.Routes.PaperUserRoutes.DocsListContinueAsync" />.</param>
        public ListPaperDocsResponse(col.IEnumerable<string> docIds,
                                     Cursor cursor,
                                     bool hasMore)
        {
            var docIdsList = enc.Util.ToList(docIds);

            if (docIds == null)
            {
                throw new sys.ArgumentNullException("docIds");
            }

            if (cursor == null)
            {
                throw new sys.ArgumentNullException("cursor");
            }

            this.DocIds = docIdsList;
            this.Cursor = cursor;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListPaperDocsResponse" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public ListPaperDocsResponse()
        {
        }

        /// <summary>
        /// <para>The list of Paper doc ids that can be used to access the given Paper docs or
        /// supplied to other API methods. The list is sorted in the order specified by the
        /// initial call to <see cref="Dropbox.Api.Paper.Routes.PaperUserRoutes.DocsListAsync"
        /// />.</para>
        /// </summary>
        public col.IList<string> DocIds { get; protected set; }

        /// <summary>
        /// <para>Pass the cursor into <see
        /// cref="Dropbox.Api.Paper.Routes.PaperUserRoutes.DocsListContinueAsync" /> to
        /// paginate through all files. The cursor preserves all properties as specified in the
        /// original call to <see cref="Dropbox.Api.Paper.Routes.PaperUserRoutes.DocsListAsync"
        /// />.</para>
        /// </summary>
        public Cursor Cursor { get; protected set; }

        /// <summary>
        /// <para>Will be set to True if a subsequent call with the provided cursor to <see
        /// cref="Dropbox.Api.Paper.Routes.PaperUserRoutes.DocsListContinueAsync" /> returns
        /// immediately with some results. If set to False please allow some delay before
        /// making another call to <see
        /// cref="Dropbox.Api.Paper.Routes.PaperUserRoutes.DocsListContinueAsync" />.</para>
        /// </summary>
        public bool HasMore { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="ListPaperDocsResponse" />.</para>
        /// </summary>
        private class ListPaperDocsResponseEncoder : enc.StructEncoder<ListPaperDocsResponse>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ListPaperDocsResponse value, enc.IJsonWriter writer)
            {
                WriteListProperty("doc_ids", value.DocIds, writer, enc.StringEncoder.Instance);
                WriteProperty("cursor", value.Cursor, writer, global::Dropbox.Api.Paper.Cursor.Encoder);
                WriteProperty("has_more", value.HasMore, writer, enc.BooleanEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="ListPaperDocsResponse" />.</para>
        /// </summary>
        private class ListPaperDocsResponseDecoder : enc.StructDecoder<ListPaperDocsResponse>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="ListPaperDocsResponse"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ListPaperDocsResponse Create()
            {
                return new ListPaperDocsResponse();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(ListPaperDocsResponse value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "doc_ids":
                        value.DocIds = ReadList<string>(reader, enc.StringDecoder.Instance);
                        break;
                    case "cursor":
                        value.Cursor = global::Dropbox.Api.Paper.Cursor.Decoder.Decode(reader);
                        break;
                    case "has_more":
                        value.HasMore = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}