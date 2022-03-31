using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XEMPHIMCSHARP
{
    
    public partial class Home : Form
    {
        
        public Home()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();

        public static class SharedVar
        {
            static public string url;
            static public string name;
        }
        public void Adddatatable()
        {
            dt.Columns.Add("URL", typeof(string));
            dt.Columns.Add("Tóm Tắt", typeof(string));
            dt.Columns.Add("Tên", typeof(string));
            dt.Columns.Add("Số Like", typeof(int));
            dt.Columns.Add("Like", typeof(int));
            dt.Columns.Add("Số view", typeof(int));
            dt.Columns.Add("Đánh Giá", typeof(int));
            dt.Columns.Add("Thời Lượng", typeof(string));
            dt.Columns.Add("Đạo Diễn", typeof(string));
            dt.Columns.Add("Quốc Gia", typeof(string));
            dt.Columns.Add("Thể Loại", typeof(string));
            dt.Columns.Add("Phát Hành", typeof(string));
            dt.Columns.Add("Diễn Viên", typeof(string));


            dt.Rows.Add("C:\\Users\\09224\\Desktop\\XemPhim\\XEMPHIMCSHARP\\resouce\\Video\\Hanhdong\\Bụi Đời Chợ Lớn .mp4","Phim xoay quanh cuộc chiến tranh giành địa bàn giữa 2 băng Đảng xã hội đen với những màn thanh toán, chém giết lẫn nhau đẫm máu", "Bụi Đời Chợ Lớn", 3,0, 121, 1, "90 Phút", "Charlie Nguyễn", "Việt Nam", "Hành Động", "2011", "Johnny Trí Nguyễn, Hoàng Phúc, Huỳnh Bích Phương");
            dt.Rows.Add("C:\\Users\\09224\\Desktop\\XemPhim\\XEMPHIMCSHARP\\resouce\\Video\\Hanhdong\\CHỊ MƯỜI BA- 3 .mp4", "anh em trong nhóm An Cư Nghĩa Đoàn đã cứu được Thái Tử - con trai anh Hai từ tay Bi Long và Bi Long đã bị dần cho nhừ tử.", "Chị Mười Ba ", 32 , 0, 1121 , 2 , " 91 Phút", "Võ Thanh Hòa ", "Việt Nam", "Hành Động", "2012", " Thu Trang, Tiến Luật, Anh Tú");
            dt.Rows.Add("C:\\Users\\09224\\Desktop\\XemPhim\\XEMPHIMCSHARP\\resouce\\Video\\Hanhdong\\Chí Phèo Ngoại Truyện - Trailer.mp4", "Nam Cao xoay quanh bi kịch cuộc đời của nhân vật Chí Phèo. Qua tác phẩm Nam Cao đã cho người đọc thấy được sự khốn cùng của con", "Chí Phèo Ngoại Truyện", 2, 0, 5, 3, "92 Phút", "Danny Đỗ", "Việt Nam", "Hành Động", "2013", "Thu Trang Tiến Luật");
            dt.Rows.Add("C:\\Users\\09224\\Desktop\\XemPhim\\XEMPHIMCSHARP\\resouce\\Video\\Hanhdong\\dibiet.mp4", "Trải qua 1 đợt huấn luyện gian khổ, cuối cùng cô đã tốt nghiệp. Sau đó Four - huấn luyện viên trường phái Dauntless, đồng thời là người yêu Tris phát hiện ra ", "Dị Biệt", 32, 0, 121, 4, "93 Phút", "Neil Burger", "Việt Nam", "Hành Động", "2014", " Shailene Woodley, Theo James, Kate Winslet");
            dt.Rows.Add("C:\\Users\\09224\\Desktop\\XemPhim\\XEMPHIMCSHARP\\resouce\\Video\\Hanhdong\\ĐỈNH MÙ SƯƠNG -.mp4", "Đỉnh mù sương là câu chuyện về Phi – một võ sĩ tự do sinh sống ở đất nước có tên là Panadi.", "Định Mù Sương", 312, 0, 1214, 1, "94 Phút", "Nguyen Hung", "Việt Nam", "Hành Động", "2015", "Peter Phạm, Simon Kook, Trường Đình Hoàng, Thạch Kim Long, Lê Thảo, Trúc Mây, NSUT Công Ninh");
            dt.Rows.Add("C:\\Users\\09224\\Desktop\\XemPhim\\XEMPHIMCSHARP\\resouce\\Video\\Hanhdong\\ÁM ẢNH .mp4", "Bộ phim Ám Ảnh kể lại câu chuyện của một nhà tâm lý học tại trường Đại học East Coast. Liệu phim sẽ diễn biến thế nào mời các bạn cùng theo dõi bộ phim Ám Ảnh.", "Ám Ảnh", 35, 0, 112, 4, "95 Phút", "Nguyen Tai", "Việt Nam", "Kinh Dị", "2016", "Hiếu Nguyễn,Yaya Trương Nhi,Trần Tuấn Lương");
            dt.Rows.Add("C:\\Users\\09224\\Desktop\\XemPhim\\XEMPHIMCSHARP\\resouce\\Video\\Hanhdong\\(Teaser Trailer) BẮC KIM THANG - KC- 25.10.2019.mp4", "Bắc Kim Thang kể về một gia đình miền Tây nặng nề hủ tục, là phim kinh dị tâm lý có cốt truyện chỉn chu và ý nghĩa nhân sinh bên cạnh các .", "Bắc Kim Thang", 32, 0, 116, 3, "96 Phút", "Nguyen Bao", "Việt Nam", "Kinh Dị", "2017", "Trịnh Tài, Minh Hy, Duy Phương, Bích Hằng, Hữu Tiến");
            dt.Rows.Add("C:\\Users\\09224\\Desktop\\XemPhim\\XEMPHIMCSHARP\\resouce\\Video\\Hanhdong\\BÓNG ĐÈ - .mp4", "Truyện xoay quanh một cô gái thành phố (được viết từ ngôi thứ nhất) kết hôn với chàng trai gốc gác nông thôn. Họ sống với nhau khá hạnh phúc dù chàng trai lắm", "Bóng Đè", 324, 0, 1114, 2, "98 Phút", "Vinh Nguyen", "Việt Nam", "Kinh Dị", "2019", "Lâm Thanh Mỹ, Quang Tuấn, Mai Cát Vi, Diệu Nhi");
            dt.Rows.Add("C:\\Users\\09224\\Desktop\\XemPhim\\XEMPHIMCSHARP\\resouce\\Video\\Hanhdong\\Phim 'Căn Hộ Của Quỷ' Trailer .mp4", " Một gia đình 6 người chuyển từ một vùng quê yên bình lên thành phố Madrid náo nhiệt và mua lại một căn hộ trong căn chung cư cũ nhờ vào việc trả góp ngân hàng.", "Căn Hộ Của Quỷ", 31, 0, 162,1, "99 Phút", "Bao Nguyen", "Việt Nam", "Kinh Dị", "2020", "Begoña Vargas , Iván Marcos , Bea Segura");
            dt.Rows.Add("C:\\Users\\09224\\Desktop\\XemPhim\\XEMPHIMCSHARP\\resouce\\Video\\Hanhdong\\(Official Trailer) CẬU VÀNG - KC- 08.01.2021.mp4", "Cảnh kết của phim khiến tôi liên tưởng đến truyện cổ tích hay một vở kịch theo mô típ ở hiền gặp lành. Vợ Ba được giải cứu và lên xe ngựa cùng", "Cậu Vàng", 8, 0, 65, 1, "100 Phút", "Tuong Nguyen", "Việt Nam", "Phim Lẻ", "2021", "NSND Thu Hà, diễn viên Hồng Diễm ");
            dt.Rows.Add("C:\\Users\\09224\\Desktop\\XemPhim\\XEMPHIMCSHARP\\resouce\\Video\\Hanhdong\\ĐÔI MẮT ÂM DƯƠNG - OFFICIAL TRAILER - Phim Tết 2020.mp4", "Bộ phim xoay quanh họa sĩ Trang (Thu Trang) - một người bị mất trí nhớ tạm thời sau tai nạn xe hơi.", "Đôi Mắt Âm Dương", 123, 0, 321, 2, "101 Phút", "Nhất Trung", "Việt Nam", "Hành Động", "2022", "Thu Trang, Quốc Trường, Bảo Thanh, NSND Ngọc Giàu, Trung Dân");
            dt.Rows.Add("C:\\Users\\09224\\Desktop\\XemPhim\\XEMPHIMCSHARP\\resouce\\Video\\Hanhdong\\trailer film Huyền thoại bất tử mới.mp4", "Chuyện phim mở đầu với cảnh một người mẹ trẻ đau đớn bỏ rơi đứa con của mình (Ðinh Y Nhung đóng),", "Huyền Thoại Bất Tử", 31, 0, 176, 2, "102 Phút", "Tuyen Nguyen", "Việt Nam", "Hành Động", "1923", "Thái Hòa, Dustin Nguyễn, Trần Bảo Sơn, Trần Thiên Tú");
            dt.Rows.Add("C:\\Users\\09224\\Desktop\\XemPhim\\XEMPHIMCSHARP\\resouce\\Video\\Hanhdong\\Kung Fu Phở [Official Trailer].mp4", "Phim Kung Fu Phở là bộ phim hài Việt Nam đầu tiên lấy đề tài ẩm thực, món ăn đặc trưng của Việt Nam là Phở.", "KungFu Phở", 31, 0, 162,  1, "103 Phút", "Quoc Duy Nguyen", "Việt Nam", "Hành Động", "1824", "Linh Sơn,Diễm My,NSƯT Mỹ Duyên");
            dt.Rows.Add("C:\\Users\\09224\\Desktop\\XemPhim\\XEMPHIMCSHARP\\resouce\\Video\\Hanhdong\\NỖI NHỚ HOÁ BĂNG - NAM EM.mp4", "Nỗi Nhớ Hóa Băng” là cảm xúc về một câu chuyện mà ở đó cô gái có tình cảm sâu đậm với một người đàn ông nhưng đau khổ khi biết rằng cô mãi mãi không thể với ...", "Nỗi Nhớ Hoá Băng", 312, 0, 1217, 5, "104 Phút", "Nam Em", "Việt Nam", "Tình Cảm", "1725", "Nam Em");
            dt.Rows.Add("C:\\Users\\09224\\Desktop\\XemPhim\\XEMPHIMCSHARP\\resouce\\Video\\Hanhdong\\7 DAYS -.mp4", "7 Ngày Yêu chính là một gia vị hoàn toàn khác biệt cho những tín đồ yêu thích dòng phim hài, lãng mạn trong tháng 10 ngập tràn dòng phim ", "7 Ngày Yêu", 35, 0, 121,1, "105 Phút", "Tran Tai", "Việt Nam", "Tình Cảm", "1226", " Lawrence de Stefano, Ananda Everingham, Nittha Jirayungyurn");
            dt.Rows.Add("C:\\Users\\09224\\Desktop\\XemPhim\\XEMPHIMCSHARP\\resouce\\Video\\Hanhdong\\BAO GIỜ CÓ YÊU NHAU' .mp4", "Cuộc gặp gỡ giữa rừng xanh nhanh chóng đưa hai tầm hồn son trẻ,", "Bao Giờ Có Yêu Nhau", 364, 0, 611, 1, "106 Phút", "Tran Tu", "Việt Nam", "Tình Cảm", "1927", " Minh Hằng, Hoài An, NS Lê Thiên, Tùng YuKi, Asley Ma, Quý Bình, NS ƯT Kim Xuân, Mai Thế Hiệp");
            dt.Rows.Add("C:\\Users\\09224\\Desktop\\XemPhim\\XEMPHIMCSHARP\\resouce\\Video\\Hanhdong\\Chị chị em em .mp4", "Xoay quanh ba nhân vật chính Thiên Kim, Huy và Bảo Nhi với mối quan hệ tình cảm phức tạp, Chị chị em em mang đến những thước phim kịch tính về lòng thù hận cùng ...", "Chị Chị Em Em", 45, 0, 176, 2, "107 Phút", "David Bao", "Việt Nam", "Tình Cảm", "1628", "Thanh Hằng,Chi Pu,Lãnh Thanh");
            dt.Rows.Add("C:\\Users\\09224\\Desktop\\XemPhim\\XEMPHIMCSHARP\\resouce\\Video\\Hanhdong\\Phim 'Mắt Biếc' .mp4", "Mắt biếc xoay quanh mối tình đơn phương của Ngạn với Hà Lan, cô bạn gái có cặp mắt hút hồn nhưng cá tính bướng bỉnh", "Mắt Biếc", 123, 0, 454, 2, "108 Phút", "Neil Ngo", "Việt Nam", "Tình Cảm", "1629", "chi Pu,Gil Lê,Bê Trần");
            dt.Rows.Add("C:\\Users\\09224\\Desktop\\XemPhim\\XEMPHIMCSHARP\\resouce\\Video\\Hanhdong\\NĂM BƯỚC ĐỂ YÊU.mp4", "Nội dung của bộ phim kể về câu chuyện tình của 2 người bệnh nhân mắc bệnh u xơ nang - Will (Cole Sprouse) và Stella (Haley Lu Richardson). ", "Năm Bước Để Yêu", 12, 0, 53, 4, "109 Phút", "Vinh Ton", "Việt Nam", "Tình Cảm", "1530", "Haley Lu Richardson, Cole Sprouse, Moises Arias");
            dt.Rows.Add("C:\\Users\\09224\\Desktop\\XemPhim\\XEMPHIMCSHARP\\resouce\\Video\\Hanhdong\\Phim Yêu .mp4", " Mối tình đồng tính lãng mạn update 2022 - LADIGI Academy -", "Yêu", 123, 0, 192, 2, "110 Phút", "Tai Ton", "Việt Nam", "Tình Cảm", "1931", "Chi Pu,Gil Lê,Bê Trần");
            dt.Rows.Add("C:\\Users\\09224\\Desktop\\XemPhim\\XEMPHIMCSHARP\\resouce\\Video\\Hanhdong\\TÂM SẮC TẤM - Official Trailer - WebDrama - Ngọc Thanh Tâm, Trấn Thành, Lê Giang, Quang Trung,....mp4", "Chỉ vỏn vẹn trong 3 chữ thôi mà Tâm Sắc Tấm đã có thể thể hiện được cái hồn và chủ đề của web drama lần này rồi. Từ tựa phim thì Tâm có thể ", "Tâm Sắc Tấm", 12, 0, 121, 1, "111 Phút", "DavidTon", "Việt Nam", "Tình Cảm", "1531", "Chi Pu,Gil Lê,Bê Trần");
            dt.Rows.Add("C:\\Users\\09224\\Desktop\\XemPhim\\XEMPHIMCSHARP\\resouce\\Video\\Hanhdong\\tranquyen.mp4", "andoraThằn Lằn Lươn Lẹo (Review Phim) Trận Chiến Ở Jangsari ", "Trận Quyền", 34, 0, 112, 1, "112 Phút", "Võ  David", "Việt Nam", "Tình Cảm", "1632", "Chi Pu,Gil Lê,Bê Trần");
            dt.Rows.Add("C:\\Users\\09224\\Desktop\\XemPhim\\XEMPHIMCSHARP\\resouce\\Video\\Hanhdong\\Chung Cư Trailer 2.mp4", "Một đám quái vật khát máu & những cư dân vô tội cùng bị mắc kẹt trong một chung cư đã cũ. Trong số các cư dân của chung cư, nổi bật nhất có một thiếu niên ...", "Chung Cư", 31, 0, 1212, 1, "113 Phút", "DavidTon", "Việt Nam", "Kinh Dị", "1733", "Chi Pu,Gil Lê,Bê Trần");
            dt.Rows.Add("C:\\Users\\09224\\Desktop\\XemPhim\\XEMPHIMCSHARP\\resouce\\Video\\Hanhdong\\GÃ HỀ MA QUÁI 2 .mp4", "Phim kể về bảy đứa trẻ sống tại bang Maine và hành trình khám phá, tiêu diệt một thực thể ngoài hành tinh có nhiều khả năng đặc biệt là It (tên tiếng Việt: Nó) .", "Gã Hề Ma Quái", 399, 0, 1247, 2, "114 Phút", "Tai David ", "Việt Nam", "Kinh Dị", "1534", "Chi Pu,Gil Lê,Bê Trần");
            dt.Rows.Add("C:\\Users\\09224\\Desktop\\XemPhim\\XEMPHIMCSHARP\\resouce\\Video\\Hanhdong\\Trailer Phim Mặt Nạ Máu.mp4", "Phim kể lại câu chuyện nữ ca sĩ Khiết Đan làm vợ bé của một đại gia tên Nguyễn ở Đà Lạt, có một đứa con trai.", "Mặt Nạ Máu", 321, 0, 1221, 4, "115 Phút", "Neil Ton", "Việt Nam", "Kinh Dị", "1635", "Chi Pu,Gil Lê,Bê Trần");
            dt.Rows.Add("C:\\Users\\09224\\Desktop\\XemPhim\\XEMPHIMCSHARP\\resouce\\Video\\Hanhdong\\Mỹ Nhân Ngư .mp4", "Mỹ nhân ngư là câu chuyện kể về tộc người cá sinh sống tại vùng vịnh Thanh La, nơi bị ô nhiễm nặng nề do sự hủy hoại của loài người.", "Mỹ Nhân Ngư", 35, 0, 111, 4, "112 Phút", "Tai Neil", "Việt Nam", "Kinh Dị", "1932", "Chi Pu,Gil Lê,Bê Trần");
            dt.Rows.Add("C:\\Users\\09224\\Desktop\\XemPhim\\XEMPHIMCSHARP\\resouce\\Video\\Hanhdong\\BÍ ẨN SONG SINH' .mp4", "Cốt truyện Song sinh bí ẩn không mới nhưng phim có cách kể chuyện thu hút. Thân phận giữa Dương và Nguyệt vốn chỉ hai chị em biết,", "Bí Ẩn Song Sinh", 312, 0, 1425, 1, "113 Phút", "Tai Ton", "Việt Nam", "Kinh Dị", "21633", "Thái Hòa, Dustin Nguyễn, Trần Bảo Sơn");
            dt.Rows.Add("C:\\Users\\09224\\Desktop\\XemPhim\\XEMPHIMCSHARP\\resouce\\Video\\Hanhdong\\NHẮM MẮT THẤY MÙA HÈ - .mp4", "Nhắm mắt thấy mùa hè là một bộ phim thuộc dòng lãng mạn và hành trình, kể về một cuộc gặp gỡ có tính định mệnh giữa hai con người đến từ hai nền văn hóa khác", "Nhắm Mắt Thấy Mùa Hè", 323, 0, 1122, 1, "114 Phút", "Bao Bao", "Việt Nam", "Tình Cảm", "1834", "Chi Pu,Gil Lê,Bê Trần");
            dt.Rows.Add("C:\\Users\\09224\\Desktop\\XemPhim\\XEMPHIMCSHARP\\resouce\\Video\\Hanhdong\\TÌNH YÊU VÀ THAM VỌNG.mp4", "Tình yêu và tham vọng xoay quanh câu chuyện tranh đấu giữa Minh (Nhan Phúc Vinh), Tổng giám đốc tập đoàn Hoàng Thổ và Phong (Mạnh Trường), Tổng giám đốc địa ốc ...", "Tình Yêu Và Tham Vọng", 32, 0, 111, 1, "115 Phút", "Tai Bao", "Việt Nam", "Tình Cảm", "1735", "Chi Pu,Gil Lê,Bê Trần");
            dt.Rows.Add("C:\\Users\\09224\\Desktop\\XemPhim\\XEMPHIMCSHARP\\resouce\\Video\\Hanhdong\\Phim kinh dị 'OÁN' OFFICIAL TRAILER.mp4", "Oán hận phải trả (Ruen Sai Sawart) thuộc thể loại phim tâm lý phim-tinh-cam tình cảm. Bộ phim xoay quanh cuộc đời của Pikul với những sóng gió trong cuộc ...", "Oán", 13, 0, 112, 2, "112 Phút", "Tai Ton", "Việt Nam", "Kinh Dị", "1632", "Chi Pu,Gil Lê,Bê Trần");
            dt.Rows.Add("C:\\Users\\09224\\Desktop\\XemPhim\\XEMPHIMCSHARP\\resouce\\Video\\Hanhdong\\HAI PHƯỢNG.mp4", "Bộ phim là hành trình nghẹt thở và căng thẳng của bà mẹ đơn thân Hai Phượng (Ngô Thanh Vân) khi phải đối đầu với cả một đường dây tội phạm bắt cóc và buôn bán nội tạng", "Hai Phượng", 87, 0, 111, 5, "113 Phút", "Bao Võ ", "Việt Nam", "Hành Động", "1933", "Thanh Hằng,Chi Pu,Lãnh Thanh");
            dt.Rows.Add("C:\\Users\\09224\\Desktop\\XemPhim\\XEMPHIMCSHARP\\resouce\\Video\\Hanhdong\\Hương Ga - .mp4", "Bộ phim kể về cuộc đời của cô gái tên Diệu. Sau chuyến tàu vượt biên định mệnh, cô mất đi cả gia đình và bị cướp mất sự trinh trắng. Không nơi ", "Hương Ga", 8, 0, 11, 2, "114 Phút", "Tai Ton", "Việt Nam", "Hành Động", "1934", "Chi Pu,Gil Lê,Bê Trần");
            dt.Rows.Add("C:\\Users\\09224\\Desktop\\XemPhim\\XEMPHIMCSHARP\\resouce\\Video\\Hanhdong\\Sói Cô Độc .mp4", "Nội dung phim Sói Cô Độc (Reprisal) kể về Jacob (Do Frank Grillo thủ vai), một nhân viên ngân hàng hiền lành chất phát. Jacob có một cuộc sống ...", "Sói Cô Độc", 9, 0, 14, 1, "114 Phút", "Tai Ton", "Việt Nam", "Hành Động", "1541", "Minh Hằng, Hoài An, NS Lê Thiên, Tùng YuKi");
            dt.Rows.Add("C:\\Users\\09224\\Desktop\\XemPhim\\XEMPHIMCSHARP\\resouce\\Video\\Hanhdong\\Shang-Chi.mp4", "Shang-Chi bắt đầu tập luyện võ thuật và được Văn Vũ cử đi lúc 14 tuổi để ám sát thủ lĩnh của Gang Gang. Sau khi hoàn thành nhiệm vụ của mình, một Shang-Chi bị ..", "ShangChi", 12, 0, 112, 1, "115 Phút", "Burger BurgerTon", "Việt Nam", "Hành Động", "1442", "Begoña Vargas , Iván Marcos");
            dt.Rows.Add("C:\\Users\\09224\\Desktop\\XemPhim\\XEMPHIMCSHARP\\resouce\\Video\\Hanhdong\\STARTREKr.mp4", "Bộ phim theo dấu James T. Kirk (Chris Pine) và Spock (Zachary Quinto) lên con tàu USS Enterprise, tại đây họ phải chống lại Nero (Eric Bana), một ...", "Startrek",13, 0, 111, 2, "114 Phút", "Burger Ton", "Việt Nam", "Hành Động", "1343", " Lawrence de Stefano, Ananda,Bê Trần");
            dt.Rows.Add("C:\\Users\\09224\\Desktop\\XemPhim\\XEMPHIMCSHARP\\resouce\\Video\\Hanhdong\\TRUY SÁT -r.mp4", "Truy Sát 2019 xoay quanh câu chuyện của Kim Soo-Hyun (Chang Ki-Yong) và Do Hyun Jin (Nana). Kim Soo Hyun được đào tạo trở thành sát thủ từ bé.", "Truy Sát", 39, 0, 112, 4, "115 Phút", "Tai Burger", "Việt Nam", "Hành Động", "1745", "Shailene Woodley, Theo James, Kate Winslet");
            dt.Rows.Add("C:\\Users\\09224\\Desktop\\XemPhim\\XEMPHIMCSHARP\\resouce\\Video\\Hanhdong\\SÁT THỦ- MẬT DANH.mp4", "Truy Sát 2019 xoay quanh câu chuyện của Kim Soo-Hyun (Chang Ki-Yong) và Do Hyun Jin (Nana). Kim Soo Hyun được đào tạo trở thành sát thủ từ bé.", "Sát Thủ Mật Danh", 39, 0, 112, 4, "115 Phút", "Tai Burger", "Việt Nam", "Hành Động", "1745", "Shailene Woodley, Theo James, Kate Winslet");

        }
        public void AddjpgPhimmoi()
        {
            
              
            lwload.Items.Add("Bụi Đời Chợ Lớn", 0);
            lwload.Items.Add("Chị Mười Ba", 1);
            lwload.Items.Add("Chí Phèo Ngoại Truyện", 2);
            lwload.Items.Add("Dị Biệt", 3);
            lwload.Items.Add("Định Mù Sương", 4);
            lwload.Items.Add("Ám Ảnh", 5);
            lwload.Items.Add("Bắc Kim Thang", 6);
            lwload.Items.Add("Bí Ẩn Song Sinh", 7);
            lwload.Items.Add("Bóng Đè", 8);
            lwload.Items.Add("Căn Hộ Của Quỷ", 9);
            lwload.Items.Add("Cậu Vàng", 10);
            lwload.Items.Add("Đôi Mắt Âm Dương", 11);
            lwload.Items.Add("Huyền Thoại Bất Tử", 12);
            lwload.Items.Add("KungFu Phở", 13);
            lwload.Items.Add("Nỗi Nhớ Hoá Băng", 14);
            lwload.Items.Add("7 Ngày Yêu", 15);
            lwload.Items.Add("Bao Giờ Có Yêu Nhau", 16);
            lwload.Items.Add("Chị Chị Em Em", 17);
            lwload.Items.Add("Mắt Biếc", 18);
            lwload.Items.Add("Năm Bước Để Yêu", 19);
            lwload.Items.Add("Yêu", 20);
            lwload.LargeImageList = imgload;
            lwload.View = View.LargeIcon;

            
        }
        public void AddjpgPhimhay()
        {
            lwphimhay.Items.Add("Hai Phượng", 0);
            lwphimhay.Items.Add("Hương Ga", 1);
            lwphimhay.Items.Add("Sát Thủ Mật Danh", 2);
            lwphimhay.Items.Add("ShangChi", 3);
            lwphimhay.Items.Add("StarTrek", 4);
            lwphimhay.Items.Add("Trận Quyền", 5);
            lwphimhay.Items.Add("Truy Sát", 6);
            lwphimhay.Items.Add("Nỗi Nhớ Hoá Băng", 7);
            lwphimhay.LargeImageList = imgphimhay;
            lwphimhay.View = View.LargeIcon;
        }
        public void AddjpgPhimKinhDi()
        {
            lwPhimKinhdi.Items.Add("Ám Ảnh", 0);
            lwPhimKinhdi.Items.Add("Bắc Kim Thang", 1);
            lwPhimKinhdi.Items.Add("Bí Ẩn Song Sinh", 2);
            lwPhimKinhdi.Items.Add("Bóng Đè", 3);
            lwPhimKinhdi.Items.Add("Căn Hộ Của Quỷ", 4);
            lwPhimKinhdi.Items.Add("Chung Cư", 5);
            lwPhimKinhdi.Items.Add("Gã Hề Ma Quái", 6);
            lwPhimKinhdi.Items.Add("Mặt Nạ Máu", 7);
            lwPhimKinhdi.Items.Add("Mỹ Nhân Ngư", 8);
            lwPhimKinhdi.Items.Add("Oán", 9);
            lwPhimKinhdi.LargeImageList=imgPhimKinhdi;
            lwPhimKinhdi.View = View.LargeIcon;

        }
        public void AddjpgPhimLe()
        {
            lwPhimLe.Items.Add("Cậu Vàng",0);
            lwPhimLe.Items.Add("Đôi Mắt Âm Dương", 1);
            lwPhimLe.Items.Add("Huyền Thoại Bất Tử", 2);
            lwPhimLe.Items.Add("KungFu Phở", 3);
            lwPhimLe.Items.Add("Nỗi Nhớ Hoá Băng", 4);
            lwPhimLe.Items.Add("Tâm Sắc Tấm", 5);
            lwPhimLe.Items.Add("Trận Quyền", 6);
            lwPhimLe.LargeImageList = imgPhimLe;
            lwPhimLe.View = View.LargeIcon;

        }
        public void AddjpgPhimHanhDong()
        {
            lwPhimHanhdong.Items.Add("Bụi Đời Chợ Lớn",0);
            lwPhimHanhdong.Items.Add("Chị Mười Ba", 1);
            lwPhimHanhdong.Items.Add("Chí Phèo Ngoại Truyện", 2);
            lwPhimHanhdong.Items.Add("Dị Biệt", 3);
            lwPhimHanhdong.Items.Add("Định Mù Sương", 4);
            lwPhimHanhdong.Items.Add("Hai Phượng", 5);
            lwPhimHanhdong.Items.Add("Hương Ga", 6);
            lwPhimHanhdong.Items.Add("Sát Thủ Mật Danh", 7);
            lwPhimHanhdong.Items.Add("ShangChi", 8);
            lwPhimHanhdong.Items.Add("Sói Cô Độc", 9);
            lwPhimHanhdong.Items.Add("StarTrek", 10);
            lwPhimHanhdong.LargeImageList = imgPhimHanhDong;
            lwPhimHanhdong.View = View.LargeIcon;

        }
        public void AddjpgPhimTinhcam()
        {
            lwPhimTinhcam.Items.Add("7 Ngày Yêu",0);
            lwPhimTinhcam.Items.Add("Bao Giờ Có Yêu Nhau", 1);
            lwPhimTinhcam.Items.Add("Chị Chị Em Em", 2);
            lwPhimTinhcam.Items.Add("Mắt Biếc", 3);
            lwPhimTinhcam.Items.Add("Năm Bước Để Yêu", 4);
            lwPhimTinhcam.Items.Add("Nhắm Mắt Thấy Mùa Hè", 5);
            lwPhimTinhcam.Items.Add("Tình Yêu Và Tham Vọng", 6);
            lwPhimTinhcam.Items.Add("Yêu", 7);
            lwPhimTinhcam.LargeImageList = imgPhimTinhCam;
            lwPhimTinhcam.View = View.LargeIcon;
        }
        private void Home_Load(object sender, EventArgs e)
        {
            AddjpgPhimmoi();
            AddjpgPhimhay();
            AddjpgPhimKinhDi();
            AddjpgPhimLe();
            AddjpgPhimHanhDong(); 
            AddjpgPhimTinhcam();
            Adddatatable();
            groupBox1.Visible=false;
            label1.Visible=false;

        }
        private void lbxemphim_Click(object sender, EventArgs e)
        {
            lwPhimLe.Visible = false;
            lwPhimHanhdong.Visible = false;
            lwPhimTinhcam.Visible = false;
            lwphimhay.Visible = false;
            lwPhimKinhdi.Visible = false;
            lwload.Visible = true;
            lbTenDanhsach.Text = "Danh Sách Phim Mới";

        }
        private void btnPhimHay_Click(object sender, EventArgs e)
        {
            lwPhimLe.Visible = false;
            lwPhimHanhdong.Visible = false;
            lwPhimTinhcam.Visible = false;
            lwload.Visible=false;
            lwPhimKinhdi.Visible=false;
            lwphimhay.Visible=true;
            lbTenDanhsach.Text = "Danh Sách Phim Hay";
        }

        private void btnKinhDi_Click(object sender, EventArgs e)
        {
            lwPhimLe.Visible = false;
            lwPhimHanhdong.Visible = false;
            lwPhimTinhcam.Visible = false;
            lwphimhay.Visible = false;
            lwload.Visible = false;
            lwPhimKinhdi.Visible = true;
            lbTenDanhsach.Text = "Danh Sách Phim Kinh Dị";

        }

        private void btnPhimle_Click(object sender, EventArgs e)
        {
            lwPhimHanhdong.Visible = false;
            lwPhimTinhcam.Visible = false;
            lwphimhay.Visible = false;
            lwload.Visible = false;
            lwPhimKinhdi.Visible = false;
            lwPhimLe.Visible = true;
            lbTenDanhsach.Text = "Danh Sách Phim Lẻ";

        }

        private void btnHanhDong_Click(object sender, EventArgs e)
        {
            lwPhimTinhcam.Visible = false;
            lwphimhay.Visible = false;
            lwload.Visible = false;
            lwPhimKinhdi.Visible = false;
            lwPhimLe.Visible = false;
            lwPhimHanhdong.Visible = true;
            lbTenDanhsach.Text = "Danh Sách Phim Hành Động";
        }

        private void btnTinhcam_Click(object sender, EventArgs e)
        {
            lwPhimHanhdong.Visible = false;
            lwphimhay.Visible = false;
            lwload.Visible = false;
            lwPhimKinhdi.Visible = false;
            lwPhimLe.Visible = false;
            lwPhimTinhcam.Visible = true;
            lbTenDanhsach.Text = "Danh Sách Phim Tình Cảm";
        }

        public void ItemSelectionchange(ListViewItemSelectionChangedEventArgs e)
        {
            
            string ss = "Tên='" + e.Item.Text + "'";
            DataRow[] dr = dt.Select(ss);
            lbDaodien.Text = dr[0]["Đạo Diễn"].ToString();
            lbdienvien.Text = dr[0]["Diễn Viên"].ToString();
            lbPhathanh.Text = dr[0]["Phát Hành"].ToString();
            lbquocgia.Text = dr[0]["Quốc Gia"].ToString();
            lbthoiluong.Text = dr[0]["Thời Lượng"].ToString();
            lbtheloai.Text = dr[0]["Thể Loại"].ToString();
            lbTenphim.Text = dr[0]["Tên"].ToString();
            lblike.Text = dr[0]["Số Like"].ToString();
            lbCountview.Text = dr[0]["Số view"].ToString();
            lbTomtat.Text = dr[0]["Tóm Tắt"].ToString();
            int i = Convert.ToInt32(dr[0]["Like"]);
            if (i== 0)
            {
                piclikeOFF.Visible = true;
                piclikeON.Visible = false;
            }
            else
            {
                piclikeOFF.Visible = false;
                piclikeON.Visible = true;
            }
            int a = Convert.ToInt32(dr[0]["Đánh Giá"]);
            switch (a)
            {
                case 1:Danhgia1();
                    break;
                case 2:Danhgia2();
                    break;
                case 3:Danhgia3();
                    break;
                case 4:Danhgia4();
                    break;
                case 5:Danhgia5();
                    break;
            }


            if (e.Item.Text == "Chị Mười Ba")
            {
                offhinh();
                pictureBoxChimuoi3.Visible = true;
                lbTenDanhsach.Visible = false;
                panel1.Visible = false;
                panelhinhanh.Visible = true;
                pictureExit.Visible = true;
            }
            else if (e.Item.Text == "Bụi Đời Chợ Lớn")
            {
                offhinh();
                pictureBoxbuidoicholon.Visible = true;
                lbTenDanhsach.Visible = false;
                panel1.Visible = false;
                panelhinhanh.Visible = true;
                pictureExit.Visible = true;

            }
            else if (e.Item.Text == "Chí Phèo Ngoại Truyện")
            {
                offhinh();
                pictureBoxchipheongoaitruyen.Visible = true;
                lbTenDanhsach.Visible = false;
                panel1.Visible = false;
                panelhinhanh.Visible = true;
                pictureExit.Visible = true;

            }
            else if (e.Item.Text == "Dị Biệt")
            {
                offhinh();
                pictureBoxdibiet.Visible = true;
                lbTenDanhsach.Visible = false;
                panel1.Visible = false;
                panelhinhanh.Visible = true;
                pictureExit.Visible = true;

            }
            else if (e.Item.Text == "Định Mù Sương")
            {
                offhinh();
                pictureBoxdinhmusuong.Visible = true;
                lbTenDanhsach.Visible = false;
                panel1.Visible = false;
                panelhinhanh.Visible = true;
                pictureExit.Visible = true;

            }
            else if (e.Item.Text == "Hai Phượng")
            {
                offhinh();
                pictureBoxhaiphuong.Visible = true;
                lbTenDanhsach.Visible = false;
                panel1.Visible = false;
                panelhinhanh.Visible = true;
                pictureExit.Visible = true;

            }
            else if (e.Item.Text == "Hương Ga")
            {
                offhinh();
                pictureBoxhuongga.Visible = true;
                lbTenDanhsach.Visible = false;
                panel1.Visible = false;
                panelhinhanh.Visible = true;
                pictureExit.Visible = true;

            }
            else if (e.Item.Text == "Sát Thủ Mật Danh")
            {
                offhinh();
                pictureBoxsatthumatdanh.Visible = true;
                lbTenDanhsach.Visible = false;
                panel1.Visible = false;
                panelhinhanh.Visible = true;
                pictureExit.Visible = true;

            }
            else if (e.Item.Text == "ShangChi")
            {
                offhinh();
                pictureBoxshangchi.Visible = true;
                lbTenDanhsach.Visible = false;
                panel1.Visible = false;
                panelhinhanh.Visible = true;
                pictureExit.Visible = true;


            }
            else if (e.Item.Text == "Sói Cô Độc")
            {
                offhinh();
                pictureBoxsoicodoc.Visible = true;
                lbTenDanhsach.Visible = false;
                panel1.Visible = false;
                panelhinhanh.Visible = true;
                pictureExit.Visible = true;

            }
            else if (e.Item.Text == "StarTrek")
            {
                offhinh();
                pictureBoxstartrek.Visible = true;
                lbTenDanhsach.Visible = false;
                panel1.Visible = false;
                panelhinhanh.Visible = true;
                pictureExit.Visible = true;

            }
            else if (e.Item.Text == "Ám Ảnh")
            {
                offhinh();
                pictureBoxamanh.Visible = true;
                lbTenDanhsach.Visible = false;
                panel1.Visible = false;
                panelhinhanh.Visible = true;
                pictureExit.Visible = true;

            }
            else if (e.Item.Text == "Bắc Kim Thang")
            {
                offhinh();
                pictureBoxbackimthang.Visible = true;
                lbTenDanhsach.Visible = false;
                panel1.Visible = false;
                panelhinhanh.Visible = true;
                pictureExit.Visible = true;

            }
            else if (e.Item.Text == "Bí Ẩn Song Sinh")
            {
                offhinh();
                pictureBoxbiansongsinh.Visible = true;
                lbTenDanhsach.Visible = false;
                panel1.Visible = false;
                panelhinhanh.Visible = true;
                pictureExit.Visible = true;

            }
            else if (e.Item.Text == "Bóng Đè")
            {
                offhinh();
                pictureBoxbongde.Visible = true;
                lbTenDanhsach.Visible = false;
                panel1.Visible = false;
                panelhinhanh.Visible = true;
                pictureExit.Visible = true;

            }
            else if (e.Item.Text == "Căn Hộ Của Quỷ")
            {
                offhinh();
                pictureBoxcanhocuaquy.Visible = true;
                lbTenDanhsach.Visible = false;
                panel1.Visible = false;
                panelhinhanh.Visible = true;
                pictureExit.Visible = true;

            }
            else if (e.Item.Text == "Chung Cư")
            {
                offhinh();
                pictureBoxchungcu.Visible = true;
                lbTenDanhsach.Visible = false;
                panel1.Visible = false;
                panelhinhanh.Visible = true;
                pictureExit.Visible = true;

            }
            else if (e.Item.Text == "Gã Hề Ma Quái")
            {
                offhinh();
                pictureBoxgahemaquai.Visible = true;
                lbTenDanhsach.Visible = false;
                panel1.Visible = false;
                panelhinhanh.Visible = true;
                pictureExit.Visible = true;

            }
            else if (e.Item.Text == "Mặt Nạ Máu")
            {
                offhinh();
                pictureBoxmatnamau.Visible = true;
                lbTenDanhsach.Visible = false;
                panel1.Visible = false;
                panelhinhanh.Visible = true;
                pictureExit.Visible = true;

            }
            else if (e.Item.Text == "Mỹ Nhân Ngư")
            {
                offhinh();
                pictureBoxmynhanngu.Visible = true;
                lbTenDanhsach.Visible = false;
                panel1.Visible = false;
                panelhinhanh.Visible = true;
                pictureExit.Visible = true;

            }
            else if (e.Item.Text == "Oán")
            {
                offhinh();
                pictureBoxoan.Visible = true;
                lbTenDanhsach.Visible = false;
                panel1.Visible = false;
                panelhinhanh.Visible = true;
                pictureExit.Visible = true;

            }
            else if (e.Item.Text == "Cậu Vàng")
            {
                offhinh();
                pictureBoxcauvang.Visible = true;
                lbTenDanhsach.Visible = false;
                panel1.Visible = false;
                panelhinhanh.Visible = true;
                pictureExit.Visible = true;

            }
            else if (e.Item.Text == "Đôi Mắt Âm Dương")
            {
                offhinh();
                pictureBoxdoimatamduong.Visible = true;
                lbTenDanhsach.Visible = false;
                panel1.Visible = false;
                panelhinhanh.Visible = true;
                pictureExit.Visible = true;

            }
            else if (e.Item.Text == "Huyền Thoại Bất Tử")
            {
                offhinh();
                pictureBoxhuyenthoaibattu.Visible = true;
                lbTenDanhsach.Visible = false;
                panel1.Visible = false;
                panelhinhanh.Visible = true;
                pictureExit.Visible = true;

            }
            else if (e.Item.Text == "KungFu Phở")
            {
                offhinh();
                pictureBoxkungfupho.Visible = true;
                lbTenDanhsach.Visible = false;
                panel1.Visible = false;
                panelhinhanh.Visible = true;
                pictureExit.Visible = true;

            }
            else if (e.Item.Text == "Nỗi Nhớ Hoá Băng")
            {
                offhinh();
                pictureBoxnoinhohoabang.Visible = true;
                lbTenDanhsach.Visible = false;
                panel1.Visible = false;
                panelhinhanh.Visible = true;
                pictureExit.Visible = true;

            }
            else if (e.Item.Text == "Tâm Sắc Tấm")
            {
                offhinh();
                pictureBoxtamsactam.Visible = true;
                lbTenDanhsach.Visible = false;
                panel1.Visible = false;
                panelhinhanh.Visible = true;
                pictureExit.Visible = true;

            }
            else if (e.Item.Text == "Trận Quyền")
            {
                offhinh();
                pictureBoxtranquyen.Visible = true;
                lbTenDanhsach.Visible = false;
                panel1.Visible = false;
                panelhinhanh.Visible = true;
                pictureExit.Visible = true;

            }
            else if (e.Item.Text == "Truy Sát")
            {
                offhinh();
                pictureBoxtruysat.Visible = true;
                lbTenDanhsach.Visible = false;
                panel1.Visible = false;
                panelhinhanh.Visible = true;
                pictureExit.Visible = true;

            }
            else if (e.Item.Text == "7 Ngày Yêu")
            {
                offhinh();
                pictureBox7ngayyeu.Visible = true;
                lbTenDanhsach.Visible = false;
                panel1.Visible = false;
                panelhinhanh.Visible = true;
                pictureExit.Visible = true;

            }
            else if (e.Item.Text == "Bao Giờ Có Yêu Nhau")
            {
                offhinh();
                pictureBoxbaogiocoyeunhau.Visible = true;
                lbTenDanhsach.Visible = false;
                panel1.Visible = false;
                panelhinhanh.Visible = true;
                pictureExit.Visible = true;


            }
            else if (e.Item.Text == "Chị Chị Em Em")
            {
                offhinh();
                pictureBoxchichiemem.Visible = true;
                lbTenDanhsach.Visible = false;
                panel1.Visible = false;
                panelhinhanh.Visible = true;
                pictureExit.Visible = true;

            }
            else if (e.Item.Text == "Mắt Biếc")
            {
                offhinh();
                pictureboxMatbiec.Visible = true;
                lbTenDanhsach.Visible = false;
                panel1.Visible = false;
                panelhinhanh.Visible = true;
                pictureExit.Visible = true;

            }
            else if (e.Item.Text == "Nhắm Mắt Thấy Mùa Hè")
            {
                offhinh();
                pictureBoxnhammatthaymuahe.Visible = true;
                lbTenDanhsach.Visible = false;
                panel1.Visible = false;
                panelhinhanh.Visible = true;
                pictureExit.Visible = true;

            }
            else if (e.Item.Text == "Tình Yêu Và Tham Vọng")
            {
                offhinh();
                pictureBoxtinhyeuvathamvong.Visible = true;
                lbTenDanhsach.Visible = false;
                panel1.Visible = false;
                panelhinhanh.Visible = true;
                pictureExit.Visible = true;

            }
            else if (e.Item.Text == "Yêu")
            {
                offhinh();
                pictureBoxyeu.Visible = true;
                lbTenDanhsach.Visible = false;
                panel1.Visible = false;
                panelhinhanh.Visible = true;
                pictureExit.Visible = true;

            }
            else if (e.Item.Text == "Năm Bước Để Yêu")
            {
                offhinh();
                pictureBoxnambuocdeyeu.Visible = true;
                lbTenDanhsach.Visible = false;
                panel1.Visible = false;
                panelhinhanh.Visible = true;
                pictureExit.Visible = true;

            }
            SharedVar.url = (string)dr[0]["URL"];
            SharedVar.name= (string)dr[0]["Tên"];
            groupBox1.Visible = true;
            label1.Visible = true;
        }
        public void offhinh()
        {
            pictureBoxamanh.Visible=false;
            pictureBox7ngayyeu.Visible=false;
            pictureBoxbackimthang.Visible=false;
            pictureBoxbiansongsinh.Visible=false;
            pictureBoxbongde.Visible=false;
            pictureBoxbuidoicholon.Visible=false;
            pictureBoxchichiemem.Visible=false;
            pictureBoxcanhocuaquy.Visible = false;
            pictureBoxChimuoi3.Visible=false;
            pictureBoxchipheongoaitruyen.Visible=false;
            pictureBoxdinhmusuong.Visible=false;
            pictureBoxhaiphuong.Visible=false;
            pictureBoxhuongga.Visible=false;
            pictureBoxhuyenthoaibattu.Visible=false;
            pictureBoxkungfupho.Visible = false;
            pictureBoxmatnamau.Visible=false;
            pictureBoxmynhanngu.Visible=false;
            pictureBoxnhammatthaymuahe.Visible=false;
            pictureBoxoan.Visible=false;
            pictureBoxshangchi.Visible=false;
            pictureBoxstartrek.Visible=false;
            pictureBoxtinhyeuvathamvong.Visible=false;
            pictureBoxtranquyen.Visible=false;
            pictureBoxtruysat.Visible=false;
            pictureBoxyeu.Visible=false;
            pictureBoxnoinhohoabang.Visible=false;
            pictureBoxnambuocdeyeu.Visible=false;
            pictureBoxgahemaquai.Visible=false;
            pictureBoxchungcu.Visible=false;
            pictureBoxdoimatamduong.Visible=false;
            pictureBoxgahemaquai.Visible = false;
            pictureBoxsoicodoc.Visible=false;
            pictureBoxsatthumatdanh.Visible=false;
            pictureBoxdibiet.Visible=false;
            pictureBoxcauvang.Visible=false;
            pictureBoxtamsactam.Visible=false;
            pictureboxMatbiec.Visible=false;
            pictureBoxbaogiocoyeunhau.Visible=false;
            
        }
        private void piclikeOFF_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(lblike.Text);
            i++;
            lblike.Text = i.ToString();
            piclikeOFF.Visible = false;
            piclikeON.Visible = true;
            string ss = "Tên='" + lbTenphim.Text + "'";
            DataRow[] dr = dt.Select(ss);
            dr[0]["Số Like"] = lblike.Text;
            dr[0]["Like"] = 1;
        }
        private void piclikeON_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(lblike.Text);
            i--;
            lblike.Text = i.ToString();
            piclikeOFF.Visible = true;
            piclikeON.Visible = false;
            string ss = "Tên='" + lbTenphim.Text + "'";
            DataRow[] dr = dt.Select(ss);
            dr[0]["Số Like"] = lblike.Text;
            dr[0]["Like"] = 0;

        }
        public void Danhgia1()
        {
            picstaron1.Visible = true;
            picstaron2.Visible = false;
            picstaron3.Visible = false;
            picstaron4.Visible = false;
            picstaron5.Visible = false;
            picstaroff1.Visible = false;
            picstaroff2.Visible = true;
            picstaroff3.Visible = true;
            picstaroff4.Visible = true;
            picstaroff5.Visible = true;
        }
        public void Danhgia2()
        {
            picstaron1.Visible = true;
            picstaron2.Visible = true;
            picstaron3.Visible = false;
            picstaron4.Visible = false;
            picstaron5.Visible = false;
            picstaroff1.Visible = false;
            picstaroff2.Visible = false;
            picstaroff3.Visible = true;
            picstaroff4.Visible = true;
            picstaroff5.Visible = true;
        }
        public void Danhgia3()
        {
            picstaron1.Visible = true;
            picstaron2.Visible = true;
            picstaron3.Visible = true;
            picstaron4.Visible = false;
            picstaron5.Visible = false;
            picstaroff1.Visible = false;
            picstaroff2.Visible = false;
            picstaroff3.Visible = false;
            picstaroff4.Visible = true;
            picstaroff5.Visible = true;
        }
        public void Danhgia4()
        {
            picstaron1.Visible = true;
            picstaron2.Visible = true;
            picstaron3.Visible = true;
            picstaron4.Visible = true;
            picstaron5.Visible = false;
            picstaroff1.Visible = false;
            picstaroff2.Visible = false;
            picstaroff3.Visible = false;
            picstaroff4.Visible = false;
            picstaroff5.Visible = true;
        }
        public void Danhgia5()
        {
            picstaron1.Visible = true;
            picstaron2.Visible = true;
            picstaron3.Visible = true;
            picstaron4.Visible = true;
            picstaron5.Visible = true;
            picstaroff1.Visible = false;
            picstaroff2.Visible = false;
            picstaroff3.Visible = false;
            picstaroff4.Visible = false;
            picstaroff5.Visible = false;
        }
        private void picstaroff1_Click(object sender, EventArgs e)
        {
            Danhgia1();
            string ss = "Tên='" + lbTenphim.Text + "'";
            DataRow[] dr = dt.Select(ss);
            dr[0]["Đánh Giá"] = 1;
        }
        private void picstaroff2_Click(object sender, EventArgs e)
        {
            Danhgia2();
            string ss = "Tên='" + lbTenphim.Text + "'";
            DataRow[] dr = dt.Select(ss);
            dr[0]["Đánh Giá"] = 2;
        }
        private void picstaroff3_Click(object sender, EventArgs e)
        {
            Danhgia3();
            string ss = "Tên='" + lbTenphim.Text + "'";
            DataRow[] dr = dt.Select(ss);
            dr[0]["Đánh Giá"] = 3;
        }
        private void picstaroff4_Click(object sender, EventArgs e)
        {
            Danhgia4();
            string ss = "Tên='" + lbTenphim.Text + "'";
            DataRow[] dr = dt.Select(ss);
            dr[0]["Đánh Giá"] = 4;
        }
        private void picstaroff5_Click(object sender, EventArgs e)
        {
            Danhgia5();
            string ss = "Tên='" + lbTenphim.Text + "'";
            DataRow[] dr = dt.Select(ss);
            dr[0]["Đánh Giá"] = 5;
        }
        private void picstaron2_Click(object sender, EventArgs e)
        {
            Danhgia2();
            string ss = "Tên='" + lbTenphim.Text + "'";
            DataRow[] dr = dt.Select(ss);
            dr[0]["Đánh Giá"] = 2;
        }
        private void picstaron3_Click(object sender, EventArgs e)
        {
            Danhgia3();
            string ss = "Tên='" + lbTenphim.Text + "'";
            DataRow[] dr = dt.Select(ss);
            dr[0]["Đánh Giá"] = 3;
        }
        private void picstaron1_Click_1(object sender, EventArgs e)
        {
            Danhgia1();
            string ss = "Tên='" + lbTenphim.Text + "'";
            DataRow[] dr = dt.Select(ss);
            dr[0]["Đánh Giá"] = 1;
        }
        private void picstaron4_Click_1(object sender, EventArgs e)
        {
            Danhgia4();
            string ss = "Tên='" + lbTenphim.Text + "'";
            DataRow[] dr = dt.Select(ss);
            dr[0]["Đánh Giá"] = 4;
        }
        private void picstaron5_Click_1(object sender, EventArgs e)
        {
            Danhgia5();
            string ss = "Tên='" + lbTenphim.Text + "'";
            DataRow[] dr = dt.Select(ss);
            dr[0]["Đánh Giá"] = 5;
        }

        private void lwPhimLe_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ItemSelectionchange(e);

        }

        private void lwPhimTinhcam_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ItemSelectionchange(e);

        }

        private void lwPhimHanhdong_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ItemSelectionchange(e);

        }

        private void lwPhimKinhdi_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ItemSelectionchange(e);

        }

        private void lwphimhay_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ItemSelectionchange(e);

        }

        private void lwload_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ItemSelectionchange(e);

        }

        private void pictureExit_Click(object sender, EventArgs e)
        {
            lbTenDanhsach.Visible = true;
            panel1.Visible = true;
            panelhinhanh.Visible = false;
            pictureExit.Visible = false;
            label1.Visible=false;
        }

        public void pictureBox3_Click(object sender, EventArgs e)
        {
            Video video = new Video();
            video.ShowDialog();
             int i=Convert.ToInt32(lbCountview.Text) +1;
            lbCountview.Text=i.ToString();
            string ss = "Tên='" + lbTenphim.Text + "'";
            DataRow[] dr = dt.Select(ss);
            dr[0]["Số View"] = i;

        }

      
    }
    
}
