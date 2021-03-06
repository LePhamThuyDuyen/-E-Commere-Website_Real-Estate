import React, { useState, useEffect } from "react";
import { Button, Table } from "reactstrap";
import { Link } from "react-router-dom";
import LoaiBatDongSanService from "../../Services/LoaiBatDongSanService";
import"./LoaiBDS.css";

const ListLoaiBDS = () => {
  const [categories, setcategories] = useState([]);
  const [itemSelected, setSelected] = React.useState(null);
  let params = {};
  useEffect(() => {
    params = {     
      query: "",
    };
    _fetchCategory();
  }, []);


  const _fetchCategory = () => {
    LoaiBatDongSanService.getList().then(({ data }) => setcategories(data));
  };
  const handleCreate = () => setSelected({ Name: "", TypeProductId: 0 });

  const handleDelete = (itemId) => {
    let result = window.confirm("Delete this item?");
    if (result) {
      LoaiBatDongSanService.delete(itemId).then((resp) => {
        setcategories(_removeViewItem(categories, itemId));
      });
    }
  };

  const _removeViewItem = (lists, itemDel) =>
    lists.filter((item) => item.categoryID !== itemDel);

    const handleSearch = (query) => {
      params.query = query;
      _fetchCategory();
    };
  
    const handleSearchKey = () => {
      params.query = "";
      _fetchCategory();
    };
  

  return (
    <div class="content-wrapper">
      <br />
      <h3 className=" sidebar-light-primary elevation-2" id="h3"><b>Danh sách loại bất động sản</b></h3> 
      <br />
      <div className="text-right">
        <div className="row" style={{ marginLeft: "500px" }}>
          <div class="col-sm-6"  >
            <div className="input-group " data-widget="sidebar-search"  >
              <input       
                className="form-control form-control-sidebar"
                type="search"
                placeholder="Search"
                aria-label="Search"
              />
              <div className="input-group-append" style={{border: "1px dotted #e0dcdc"}}>
                <button className="btn btn-sidebar">
                  <i className="fas fa-search fa-fw"></i>
                </button>
                
              </div>
            </div>
          </div>
          <div class="col-sm-2" style={{ marginLeft: "100px"
        }}>
            <Link to={`/createLoaibatdongsan/`}>
              <Button className="create elevation-2"  style={{ width: "100px"}}>
               <b> Thêm </b>
              </Button>
            </Link>
          </div>
        </div>
        
      </div>
      <br/>
      <Table className="elevation-2" style ={{backgroundColor : "#e9d8f4", bordercollapse:"collapse",width:"1300px",marginLeft:"100px"}}>
     
        <thead>
          <tr style ={{backgroundColor : "#58257b", color:"white",fontSize:"18px"}}>
            <th>STT</th>
            <th>Mã Loại Bất Động Sản</th>
            <th>Tên Loại Bất Động Sản</th>
            <th>Mô Tả</th>
            <th></th>
            <th></th>
          </tr>
        </thead>
        <tbody>
          {categories.map(function (item, i) {
            return (
              <tr>
                <th scope="row">{i + 1}</th>
                <td>{item.categoryName}</td>
                <td>{item.description}</td>
                <td>{item.categoryID}</td>
                <td className="text-right">
                  <Link to={`/Editloaibatdongsany/${item.categoryID}`}>
                    <i
                      className="fas fa-edit"
                      style={{
                        marginLeft: "10px",
                        marginRight: "80px",
                        fontSize: "20px",
                      }}
                    >
                      {" "}
                    </i>
                  </Link>
                  <i
                    className="fas fa-trash-alt"
                    style={{
                      marginLeft: "10px",
                      marginRight: "80px",
                      fontSize: "20px",
                      color: "#E54646",
                    }}
                    onClick={() => handleDelete(item.categoryID)}
                  ></i>
                </td>
              </tr>
            );
          })}
        </tbody>
      </Table>
    </div>
  );
};

export default ListLoaiBDS;
