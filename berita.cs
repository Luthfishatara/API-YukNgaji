using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Test
{
    #region Berita
    public class Berita
    {
        #region Member Variables
        protected int _berita_id;
        protected string _title_berita;
        protected string _subtitle_berita;
        protected string _image_berita;
        protected string _isi_berita;
        #endregion
        #region Constructors
        public Berita() { }
        public Berita(string title_berita, string subtitle_berita, string image_berita, string isi_berita)
        {
            this._title_berita=title_berita;
            this._subtitle_berita=subtitle_berita;
            this._image_berita=image_berita;
            this._isi_berita=isi_berita;
        }
        #endregion
        #region Public Properties
        public virtual int Berita_id
        {
            get {return _berita_id;}
            set {_berita_id=value;}
        }
        public virtual string Title_berita
        {
            get {return _title_berita;}
            set {_title_berita=value;}
        }
        public virtual string Subtitle_berita
        {
            get {return _subtitle_berita;}
            set {_subtitle_berita=value;}
        }
        public virtual string Image_berita
        {
            get {return _image_berita;}
            set {_image_berita=value;}
        }
        public virtual string Isi_berita
        {
            get {return _isi_berita;}
            set {_isi_berita=value;}
        }
        #endregion
    }
    #endregion
}