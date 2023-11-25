
function addHeader() {
    document.write(`        
	<header>
        <div class="logo">
            <a href=""><img src="../assets/img/logo.png" alt=""></a>
        </div>
        <div class="menu">
            <li><a href="">NỮ</a>
                <ul class="sub-menu">
                    <li><a href="">Áo</a></li>
                        <ul>
                            <li><a href="">Áo sơ mi</a></li>
                            <li><a href="">Áo thun</a></li>
                            <li><a href="">Áo kiểu</a></li>
                            <li><a href="">Áo croptop</a></li>
                            <li><a href="">Áo vest</a></li>
                        </ul>
                    <li><a href="">Quần</a></li>
                        <ul>
                            <li><a href="">Quần jeans</a></li>
                            <li><a href="">Quần dài</a></li>
                            <li><a href="">Quần Lửng</a></li>
                        </ul>
                </ul>
            </li>
            <li><a href="">NAM</a>
                <ul class="sub-menu">
                    <li><a href="">Áo</a></li>
                        <ul>
                            <li><a href="">Áo sơ mi</a></li>
                            <li><a href="">Áo thun</a></li>
                            <li><a href="">Áo vest</a></li>
                        </ul>
                    <li><a href="">Quần</a></li>
                        <ul>
                            <li><a href="">Quần jeans</a></li>
                            <li><a href="">Quần dài</a></li>
                            <li><a href="">Quần Lửng</a></li>
                        </ul>
                </ul>
            </li>
            <li><a href="">TRẺ EM</a>
                <ul class="sub-menu">
                    <li><a href="">Bé trai</a></li>
                        <ul>
                            <li><a href="">Áo bé trai</a></li>
                            <li><a href="">Quần bé trai</a></li>
                            <li><a href="">Phụ kiện</a></li>
                        </ul>
                    <li><a href="">Bé gái</a></li>
                        <ul>
                            <li><a href="">Áo bé gái</a></li>
                            <li><a href="">Quần bé gái</a></li>
                            <li><a href="">Váy bé gái</a></li>
                            <li><a href="">Chân váy</a></li>
                            <li><a href="">Phụ kiện</a></li>
                        </ul>
                </ul>
            </li>
            <li><a href="" style="color: red;">SALE</a>
                <ul class="sub-menu">
                    <li><a href="">Giảm 70%</a></li>
                        <ul>
                            <li><a href="">Nam</a></li>
                            <li><a href="">Nữ</a></li>
                            <li><a href="">Trẻ em</a></li>
                        </ul>
                </ul>
            </li>
            <li><a href="" >LIFESTYLE </a></li>
            <li><a href="">VỀ CHÚNG TÔI</a></li>
        </div>
        <div class="others">
            <li><input placeholder="Tìm kiếm" type="text"><i class="fa-solid fa-magnifying-glass"></i></li>
            <li><i class="fa-solid fa-headphones"></i></li>
            <li><i class="fa-regular fa-user"></i></li>
            <li><i class="fa-solid fa-cart-shopping"></i></li>
        </div>

    </header>
    `)
}

function addFooter() {
    document.write(`
    <footer>
        <section class="app-container">
            <p>Tải ứng dụng IVY moda</p>
            <div class="app-google">
                <a href=""><img src="/assets/img/appstore.png" alt=""></a>
                <a href=""><img src="/assets/img/googleplay.png" alt=""></a>
            </div>
            <p>Nhận bản tin IVY moda</p>
            <input type="text" placeholder="Nhập email của bạn...">
        </section>
        <!-------------footer------------->
        <div class="footer-top">
            <li><a href=""><img src="/assets/img/img-congthuong.png" alt=""></a></li>
            <li><a href=""></a>Liên hệ</li>
            <li><a href=""></a>Tuyển dụng</li>
            <li><a href=""></a>Giới thiệu</li>
            <li>
                <a href="" class="fab fa-facebook-f"></a>
                <a href="" class="fab fa-twitter"></a>
                <a href="" class="fab fa-youtube"></a>
            </li>
        </div>
        <div class="footer-center">
            <p class="text">
                Công ty Cổ phần Dự Kim với số đăng ký kinh doanh: 0105777650<br>
                Địa chỉ đăng ký: Tổ dân phố Tháp, P.Đại Mỗ, Q.Nam Từ Liêm, TP.Hà Nội, Việt Nam<br>
                Số điện thoại:<b>0243 205 2222/ 090 589 8683</b><br>
                Email: cskh@ivy.com.vn
            </p>
        </div>
        <div class="footer-bottom">
            ©IVYmoda All rights reserved
        </div>
    
    
    </footer>
    `);

}